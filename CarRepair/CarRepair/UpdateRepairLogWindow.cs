using System;

namespace CarRepair
{
	public partial class UpdateRepairLogWindow : Gtk.Window
	{
		public UpdateRepairLogWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

