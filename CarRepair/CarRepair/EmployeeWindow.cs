using System;
namespace CarRepair
{
	public partial class EmployeeWindow : Gtk.Window
	{

		private DataSource dataSource;

		public EmployeeWindow(DataSource dataSource) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this.dataSource = dataSource;
			populateComboBox();
		}

		private void populateComboBox()
		{
			var employees = this.dataSource.getEmployees();
			var store = new Gtk.ListStore(typeof(string));

			store.AppendValues("Novi djelatnik");

			foreach (var employee in employees)
			{
				store.AppendValues(employee.FirstName + " " + employee.LastName);
			}

			combobox1.Model = store;
			this.clearWindow();
		}

		protected void OnCombobox1Changed(object sender, EventArgs e)
		{
			var selectedUser = combobox1.ActiveText;

			if (selectedUser == "Novi djelatnik")
			{
				this.clearWindow();
			}
			else
			{
				var fullSelectedUser = this.dataSource.getEmployeeByFullName(selectedUser);
				this.populateWindow(
					fullSelectedUser.FirstName,
					fullSelectedUser.LastName,
					fullSelectedUser.Oib,
					fullSelectedUser.EmploymentDate.ToString(),
					fullSelectedUser.BirthDate.ToString(),
					fullSelectedUser.Username,
					fullSelectedUser.Password,
					fullSelectedUser.Admin
				);	
			}
		}

		private void populateWindow(string firstName, string lastName, string OIB, string startDate, string birthDate, string username, string password, bool isAdmin)
		{
			firstNameEntry.Text = firstName;
			lastNameEntry.Text = lastName;
			oibEntry.Text = OIB;
			startDateEntry.Text = startDate;
			birthDateEntry.Text = birthDate;
			usernameEntry.Text = username;
			passwordEntry.Text = password;
			checkbutton1.Active = isAdmin;
		}

		private void clearWindow()
		{
			firstNameEntry.Text = "";
			lastNameEntry.Text = "";
			oibEntry.Text = "";
			startDateEntry.Text = "";
			birthDateEntry.Text = "";
			usernameEntry.Text = "";
			passwordEntry.Text = "";
			checkbutton1.Active = false;
		}

		protected void OnButton27Clicked(object sender, EventArgs e)
		{
			var selectedUser = combobox1.ActiveText;

			if (selectedUser == "Novi djelatnik")
			{
				this.dataSource.addEmployee(
					firstNameEntry.Text,
					lastNameEntry.Text,
					oibEntry.Text,
					usernameEntry.Text,
					passwordEntry.Text,
					startDateEntry.Text,
					birthDateEntry.Text,
					checkbutton1.Active
				);
                this.populateComboBox();
			}
			else
			{
				var fullSelectedUser = this.dataSource.getEmployeeByFullName(selectedUser);
				fullSelectedUser.FirstName = firstNameEntry.Text;
				fullSelectedUser.LastName = lastNameEntry.Text;
				fullSelectedUser.Oib = oibEntry.Text;
				fullSelectedUser.Admin = checkbutton1.Active;
				fullSelectedUser.Username = usernameEntry.Text;
				fullSelectedUser.Password = passwordEntry.Text;
				this.dataSource.updateEmployee(fullSelectedUser);
				this.populateComboBox();
			}
		}

		protected void OnButton29Clicked(object sender, EventArgs e)
		{
			var selectedUser = combobox1.ActiveText;

			if (selectedUser != "Novi djelatnik")
			{
				this.dataSource.deleteUserByFullName(selectedUser);
				this.populateComboBox();
			}
		}
	}
}
