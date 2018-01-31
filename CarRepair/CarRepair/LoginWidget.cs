using System;
namespace CarRepair
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class LoginWidget : Gtk.Bin
	{
		private MainWindow mainWindow;

		public LoginWidget(MainWindow mainWindow)
		{
			this.Build();
			this.mainWindow = mainWindow;
			//this.mainWindow.Authorize("abilos", "password", this.showErrorMessage);
		}

		protected void OnButton3Clicked(object sender, EventArgs e)
		{
			this.mainWindow.Authorize(entry5.Text, entry7.Text, this.showErrorMessage);
		}

		public int showErrorMessage(string message)
		{
			label10.Text = message;
			return 1;
		}
	}
}
