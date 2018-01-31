using System;
using System.Collections.Generic;

namespace CarRepair
{
	public partial class RepairListWindow : Gtk.Window
	{
		private DataSource dataSource;
		private Gtk.NodeStore store;
		public RepairListWindow(DataSource dataSource) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this.dataSource = dataSource;
			store = InitGridAndCreateStore ();
			ClearStorageAndLoadData ();
		}

		private Gtk.NodeStore InitGridAndCreateStore(){
			Gtk.NodeStore store = new Gtk.NodeStore (typeof (RepairRow));
			Gtk.NodeView myNodeView = new Gtk.NodeView(store);

			myNodeView.AppendColumn ("Owner", new Gtk.CellRendererText (), "text", 0);
			myNodeView.AppendColumn ("Vehicle type", new Gtk.CellRendererText (), "text", 1);
			myNodeView.AppendColumn ("Registration", new Gtk.CellRendererText (), "text", 2);
			myNodeView.AppendColumn ("WorkDescription", new Gtk.CellRendererText (), "text", 3);
			myNodeView.AppendColumn ("ReceivedDate", new Gtk.CellRendererText (), "text", 4);

			myNodeView.ButtonPressEvent += OnTreeViewButtonPressEvent;

			myNodeView.ShowAll ();
			Add (myNodeView);
			return store;
		}

		public void ClearStorageAndLoadData(){
			store.Clear ();
			List<RepairLog> logs = getRepairLogs ();
			foreach(var l in logs){
				store.AddNode (new RepairRow (l.Id, l.VehicleType, l.VehicleOwner, l.Registration, l.WorkDescription, 
					Convert.ToString(l.ReceivedDate), Gtk.Button.NewWithMnemonic("Update")));
			}

		}

		private List<RepairLog> getRepairLogs()
		{
			return this.dataSource.getConnection().CreateCommand("SELECT * FROM RepairLog WHERE finished = 0").ExecuteQuery<RepairLog>();
		}

		[GLib.ConnectBefore]
		void OnTreeViewButtonPressEvent(object sender, Gtk.ButtonPressEventArgs e)
		{
			if (e.Event.Type != Gdk.EventType.TwoButtonPress) {
				return;
			}

			int repairLogId = ((RepairRow)((Gtk.NodeView)sender).NodeSelection.SelectedNode).Id;

			var repairListWindow = new EditRepairWindow(this, dataSource, repairLogId);
			this.Add(repairListWindow);
			repairListWindow.Show();
		}    
	}

	[Gtk.TreeNode]
	public class RepairRow : Gtk.TreeNode 
	{        
		public RepairRow(int Id, string VehicleType, string VehicleOwner, string Registration, string WorkDescription, string ReceivedDate, Gtk.Button UpdateButton)
		{
			this.Id = Id;
			this.VehicleType = VehicleType;
			this.VehicleOwner = VehicleOwner;
			this.Registration = Registration;
			this.ReceivedDate = ReceivedDate;
			this.WorkDescription = WorkDescription;
			this.UpdateButton = UpdateButton;
		}

		[Gtk.TreeNodeValue(Column=0)]
		public string VehicleOwner;

		[Gtk.TreeNodeValue(Column=1)]
		public string VehicleType;

		[Gtk.TreeNodeValue(Column=2)]
		public string Registration;

		[Gtk.TreeNodeValue(Column=3)]
		public string WorkDescription;

		[Gtk.TreeNodeValue(Column=4)]
		public string ReceivedDate;

		[Gtk.TreeNodeValue(Column=5)]
		public Gtk.Button UpdateButton;

		public int Id;
	}
}