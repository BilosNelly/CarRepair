using System;
using Gtk;

namespace CarRepair
{
	public partial class AddRepairWindow2 : Gtk.Window
	{

		private DataSource dataSource;

		public AddRepairWindow2(DataSource dataSource) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this.dataSource = dataSource;
		}

		private void onSaveClicked (object sender, EventArgs e)
		{
			if (!validateForm ())
				return;
			
			var log = new RepairLog () {
				VehicleType = VehicleTypeEntry.Text,
				VehicleOwner = VehicleOwnerEntry.Text,
				ReceivedDate = new DateTime (),
				Registration = RegistrationEntry.Text,
				WorkDescription = DescriptionTextView.Buffer.Text,
				Finished = false,
			};

			dataSource.getConnection ().Insert (log);
			this.Destroy ();
		}

		private bool validateForm(){
			Gdk.Color redColor = new Gdk.Color();
			Gdk.Color.Parse ("red", ref redColor);

			Gdk.Color whiteColor = new Gdk.Color();
			Gdk.Color.Parse ("white", ref whiteColor);

			if (String.IsNullOrEmpty (VehicleOwnerEntry.Text)) {
				VehicleOwnerEntry.ModifyBase (StateType.Normal, redColor);
				return false;
			} else {
				VehicleOwnerEntry.ModifyBase (StateType.Normal, whiteColor);
			}

			if (String.IsNullOrEmpty (RegistrationEntry.Text)) {
				RegistrationEntry.ModifyBase (StateType.Normal, redColor);
				return false;
			} else {
				RegistrationEntry.ModifyBase (StateType.Normal, whiteColor);
			}

			if (String.IsNullOrEmpty (VehicleTypeEntry.Text)) {
				VehicleTypeEntry.ModifyBase (StateType.Normal, redColor);
				return false;
			} else {
				VehicleTypeEntry.ModifyBase (StateType.Normal, whiteColor);
			}


			if (String.IsNullOrEmpty (DescriptionTextView.Buffer.Text)) {
				DescriptionTextView.ModifyBase (StateType.Normal, redColor);
				return false;
			} else {
				DescriptionTextView.ModifyBase (StateType.Normal, whiteColor);
			}

			return true;
		}
	}
}