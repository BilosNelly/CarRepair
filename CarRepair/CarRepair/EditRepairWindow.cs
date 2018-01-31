using System;
using Gtk;

namespace CarRepair
{
	public partial class EditRepairWindow : Gtk.Window
	{
		private DataSource dataSource;
		private int repairLogId;
		private RepairListWindow window;

		public EditRepairWindow (RepairListWindow window, DataSource dataSource, int repairLogId) :
			base (Gtk.WindowType.Toplevel)
		{
			this.dataSource = dataSource;
			this.repairLogId = repairLogId;
			this.window = window;

			this.Build ();
			populateView ();
		}

		private RepairLog findLogById(int repairLogId){
			return dataSource.getConnection ().Table<RepairLog> ()
				.Where (r => r.Id == repairLogId).FirstOrDefault ();
		}

		private void populateView() {
			RepairLog log = findLogById(repairLogId);
			if (log == null)
				return;
			
			RegistrationEntry.Text = log.Registration;
			VehicleOwnerEntry.Text = log.VehicleOwner;
			VehicleTypeEntry.Text = log.VehicleType;
			DescriptionEntry.Text = log.WorkDescription;
			populateEmployee ();
		}

		private void populateEmployee(){
			var employees = dataSource.getEmployees();
			var store = new Gtk.ListStore(typeof(string));

			foreach (var employee in employees)
			{
				store.AppendValues(employee.FirstName + " " + employee.LastName);
			}

			EmployeeComboBox.Model = store;
		}

		protected void onSaveClicked (object sender, EventArgs e)
		{
			if (!validateForm())
				return;
			
			var log = findLogById (repairLogId);
			log.Finished = true;
			log.FinishedDate = new DateTime ();
			log.Price = Convert.ToDecimal (PriceEntry.Text);
			log.WorkDescription = DescriptionEntry.Text;
			var employee = dataSource.getEmployeeByFullName (EmployeeComboBox.ActiveText);
			log.EmployeeId = employee == null ? 0 : employee.Id;

			dataSource.getConnection ().Update (log);

			this.Destroy ();
			window.ClearStorageAndLoadData ();
		}

		private bool validateForm(){
			Gdk.Color redColor = new Gdk.Color();
			Gdk.Color.Parse ("red", ref redColor);

			Gdk.Color whiteColor = new Gdk.Color();
			Gdk.Color.Parse ("white", ref whiteColor);

			if (isInvalidDecimal(PriceEntry.Text)) {
				PriceEntry.ModifyBase (StateType.Normal, redColor);
				return false;
			} else {
				PriceEntry.ModifyBase (StateType.Normal, whiteColor);
			}

			if (String.IsNullOrEmpty(EmployeeComboBox.ActiveText)) {
				EmployeeComboBox.ModifyText (StateType.Normal, redColor);
				return false;
			} else {
				EmployeeComboBox.ModifyText (StateType.Normal, whiteColor);
			}

			return true;
		}

		private bool isInvalidDecimal(string str){
			if (String.IsNullOrEmpty (PriceEntry.Text))
				return true;
			decimal dec;
			return !Decimal.TryParse (str, out dec);
		}
	}
}

