
// This file has been generated by the GUI designer. Do not modify.
namespace CarRepair
{
	public partial class AdminMenuWidget
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Alignment alignment3;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Alignment alignment6;
		
		private global::Gtk.Image image1;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.VBox vbox9;
		
		private global::Gtk.Button button15;
		
		private global::Gtk.Button button17;
		
		private global::Gtk.Button btnRepairList;
		
		private global::Gtk.Button button21;
		
		private global::Gtk.Button button25;
		
		private global::Gtk.Label GtkLabel5;
		
		private global::Gtk.Alignment alignment5;
		
		private global::Gtk.Alignment alignment7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CarRepair.AdminMenuWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "CarRepair.AdminMenuWidget";
			// Container child CarRepair.AdminMenuWidget.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.hbox1.Add (this.alignment3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment3]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.vbox2.Add (this.alignment6);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment6]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("CarRepair.logo.png");
			this.vbox2.Add (this.image1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.image1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.alignment1.Add (this.vbox2);
			this.vbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment1]));
			w5.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(2));
			this.frame1.BorderWidth = ((uint)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.TopPadding = ((uint)(12));
			this.GtkAlignment.RightPadding = ((uint)(12));
			this.GtkAlignment.BottomPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.button15 = new global::Gtk.Button ();
			this.button15.CanFocus = true;
			this.button15.Name = "button15";
			this.button15.UseUnderline = true;
			this.button15.Label = global::Mono.Unix.Catalog.GetString ("Unos/brisanje djelatnika");
			this.vbox9.Add (this.button15);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.button15]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.button17 = new global::Gtk.Button ();
			this.button17.CanFocus = true;
			this.button17.Name = "button17";
			this.button17.UseUnderline = true;
			this.button17.Label = global::Mono.Unix.Catalog.GetString ("Unos kvara ");
			this.vbox9.Add (this.button17);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.button17]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.btnRepairList = new global::Gtk.Button ();
			this.btnRepairList.CanFocus = true;
			this.btnRepairList.Name = "btnRepairList";
			this.btnRepairList.UseUnderline = true;
			this.btnRepairList.Label = global::Mono.Unix.Catalog.GetString ("Ispis kvarova");
			this.vbox9.Add (this.btnRepairList);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.btnRepairList]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.button21 = new global::Gtk.Button ();
			this.button21.CanFocus = true;
			this.button21.Name = "button21";
			this.button21.UseUnderline = true;
			this.button21.Label = global::Mono.Unix.Catalog.GetString ("Pregled odrađenog posla");
			this.vbox9.Add (this.button21);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.button21]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.button25 = new global::Gtk.Button ();
			this.button25.CanFocus = true;
			this.button25.Name = "button25";
			this.button25.UseUnderline = true;
			this.button25.Label = global::Mono.Unix.Catalog.GetString ("Odjava");
			this.vbox9.Add (this.button25);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.button25]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 4;
			w10.Expand = false;
			w10.Fill = false;
			this.GtkAlignment.Add (this.vbox9);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Izbornik</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel5;
			this.vbox1.Add (this.frame1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.vbox1.Add (this.alignment5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment5]));
			w14.Position = 2;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.hbox1.Add (this.alignment7);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment7]));
			w16.Position = 2;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.button15.Clicked += new global::System.EventHandler (this.OnButton15Clicked);
			this.button17.Clicked += new global::System.EventHandler (this.onShowRepairClicked);
			this.btnRepairList.Clicked += new global::System.EventHandler (this.onListRepairsClicked);
			this.button21.Clicked += new global::System.EventHandler (this.onShowFinishedClicked);
			this.button25.Clicked += new global::System.EventHandler (this.OnButton25Clicked);
		}
	}
}
