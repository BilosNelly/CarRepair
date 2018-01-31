using System;
using System.Collections.Generic;
using Gtk;
using CarRepair;

public partial class MainWindow : Gtk.Window
{

	private DataSource dataSource;
	private Authorization authorization;
	private Employee currentUser;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		this.dataSource = new DataSource();
		this.authorization = new Authorization(this.dataSource);

		this.showLoginWidget();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	public void Authorize(string username, string password, Func<string, int> callback)
	{
		this.currentUser = this.authorization.Authorize(username, password);
		if (this.currentUser == null)
		{
			callback("Krivo korisničko ime ili lozinka!");
		}
		else if (this.currentUser.Admin)
		{
			this.showAdminMenu();
		}
		else
		{
			// regular user
		}
	}

	public void Logout()
	{
		this.currentUser = null;
		this.clearWindow();
		this.showLoginWidget();
	}
		
	public void showEmployeeWindow()
	{
		var employeeWindow = new EmployeeWindow(dataSource);
		employeeWindow.Show();
	}

	private void showLoginWidget()
	{
		var loginWidget = new LoginWidget(this);
		this.Add(loginWidget);
		loginWidget.Show();
	}

	private void showAdminMenu()
	{
		this.clearWindow();
		var adminMenuWidget = new AdminMenuWidget(this, dataSource);
		this.Add(adminMenuWidget);
		adminMenuWidget.Show();
	}

	private void clearWindow()
	{
		foreach (var child in this.Children) {
			this.Remove(child);
		}	
	}
}
