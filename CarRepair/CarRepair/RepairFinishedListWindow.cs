using System;
using System.Collections.Generic;

namespace CarRepair
{
	public partial class RepairFinishedListWindow : Gtk.Window
	{
		private DataSource dataSource;

		public RepairFinishedListWindow(DataSource dataSource) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this.dataSource = dataSource;
			Gtk.NodeStore store = InitGridAndCreateStore ();
			LoadData (store);
		}

		private Gtk.NodeStore InitGridAndCreateStore(){
			Gtk.NodeStore store = new Gtk.NodeStore (typeof (RepairFinishedRow));
			Gtk.NodeView myNodeView = new Gtk.NodeView(store);

			myNodeView.AppendColumn ("Owner", new Gtk.CellRendererText (), "text", 0);
			myNodeView.AppendColumn ("Vehicle type", new Gtk.CellRendererText (), "text", 1);
			myNodeView.AppendColumn ("Registration", new Gtk.CellRendererText (), "text", 2);
			myNodeView.AppendColumn ("Work Description", new Gtk.CellRendererText (), "text", 3);
			myNodeView.AppendColumn ("Received Date", new Gtk.CellRendererText (), "text", 4);
			myNodeView.AppendColumn ("Finished Date", new Gtk.CellRendererText (), "text", 5);
			myNodeView.AppendColumn ("Price", new Gtk.CellRendererText (), "text", 6);
			myNodeView.AppendColumn ("Employee", new Gtk.CellRendererText (), "text", 7);
			myNodeView.ShowAll ();
			Add (myNodeView);
			return store;
		}

		private void LoadData(Gtk.NodeStore store){
			List<RepairLog> logs = getFinishedRepairLogs ();
			foreach(var l in logs){
				var employee = dataSource.getEmployeeById (l.EmployeeId);
				var employeeName = employee == null ? "" : employee.FirstName + " " + employee.LastName;
				store.AddNode (new RepairFinishedRow (l.VehicleType, l.VehicleOwner, l.Registration, l.WorkDescription, 
					Convert.ToString(l.ReceivedDate), Convert.ToString(l.FinishedDate), Convert.ToString(l.Price), employeeName));
			}

		}

		private List<RepairLog> getFinishedRepairLogs()
		{
			return this.dataSource.getConnection().CreateCommand("SELECT * FROM RepairLog WHERE finished = 1").ExecuteQuery<RepairLog>();
		}
	}

	[Gtk.TreeNode]
	public class RepairFinishedRow : Gtk.TreeNode 
	{        
		public RepairFinishedRow(string VehicleType, string VehicleOwner, string Registration, string WorkDescription, string ReceivedDate,
			string FinishedDate, string Price, string Employee)
		{
			this.VehicleType = VehicleType;
			this.VehicleOwner = VehicleOwner;
			this.Registration = Registration;
			this.ReceivedDate = ReceivedDate;
			this.WorkDescription = WorkDescription;
			this.Price = Price;
			this.FinsihedDate = FinishedDate;
			this.Employee = Employee;
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
		public string FinsihedDate;

		[Gtk.TreeNodeValue(Column=6)]
		public string Price;

		[Gtk.TreeNodeValue(Column=7)]
		public string Employee;
	}
}

