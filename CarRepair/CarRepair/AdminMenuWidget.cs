using System;
namespace CarRepair
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class AdminMenuWidget : Gtk.Bin
	{

		private MainWindow mainWindow;
		private DataSource dataSource;

		public AdminMenuWidget(MainWindow mainWindow, DataSource dataSource)
		{
			this.Build();
			this.mainWindow = mainWindow;
			this.dataSource = dataSource;
		}

		protected void OnButton25Clicked(object sender, EventArgs e)
		{
			this.mainWindow.Logout();
		}

		protected void OnButton15Clicked(object sender, EventArgs e)
		{
			this.mainWindow.showEmployeeWindow();
		}

		protected void onShowRepairClicked (object sender, EventArgs e)
		{
			var repairWindow = new AddRepairWindow2(dataSource);
			mainWindow.Add(repairWindow);
			repairWindow.Show();
		}

		protected void onListRepairsClicked (object sender, EventArgs e)
		{
			var repairListWindow = new RepairListWindow(dataSource);
			mainWindow.Add(repairListWindow);
			repairListWindow.Show();
		}

		protected void onShowFinishedClicked (object sender, EventArgs e)
		{
			var repairListWindow = new RepairFinishedListWindow(dataSource);
			mainWindow.Add(repairListWindow);
			repairListWindow.Show();
		}
	}
}
