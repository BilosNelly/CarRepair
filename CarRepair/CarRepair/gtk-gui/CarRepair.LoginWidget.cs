
// This file has been generated by the GUI designer. Do not modify.
namespace CarRepair
{
	public partial class LoginWidget
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Alignment alignment3;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Alignment alignment6;
		
		private global::Gtk.Image image3;
		
		private global::Gtk.Alignment alignment4;
		
		private global::Gtk.Alignment alignment8;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry entry5;
		
		private global::Gtk.Entry entry7;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Button button3;
		
		private global::Gtk.Label GtkLabel1;
		
		private global::Gtk.Alignment alignment5;
		
		private global::Gtk.Alignment alignment7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CarRepair.LoginWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "CarRepair.LoginWidget";
			// Container child CarRepair.LoginWidget.Gtk.Container+ContainerChild
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
			this.image3 = new global::Gtk.Image ();
			this.image3.Name = "image3";
			this.image3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("CarRepair.logo.png");
			this.vbox2.Add (this.image3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.image3]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			// Container child alignment4.Gtk.Container+ContainerChild
			this.alignment8 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment8.Name = "alignment8";
			this.alignment4.Add (this.alignment8);
			this.vbox2.Add (this.alignment4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment4]));
			w5.Position = 2;
			this.alignment1.Add (this.vbox2);
			this.vbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment1]));
			w7.Position = 0;
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
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '●';
			this.table1.Add (this.entry5);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry5]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.InvisibleChar = '●';
			this.table1.Add (this.entry7);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry7]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Korisničko ime:");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Lozinka:");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.vbox3.Add (this.label10);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label10]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString ("Prijava");
			this.vbox3.Add (this.button3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button3]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.GtkAlignment.Add (this.vbox3);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Prijava</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel1;
			this.vbox1.Add (this.frame1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.vbox1.Add (this.alignment5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment5]));
			w18.Position = 2;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.hbox1.Add (this.alignment7);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment7]));
			w20.Position = 2;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		}
	}
}
