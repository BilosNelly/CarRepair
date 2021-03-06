
// This file has been generated by the GUI designer. Do not modify.
namespace CarRepair
{
	public partial class EditRepairWindow
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Alignment alignment5;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.Alignment alignment4;
		
		private global::Gtk.VBox vbox7;
		
		private global::Gtk.VBox vbox8;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Entry VehicleOwnerEntry;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Entry RegistrationEntry;
		
		private global::Gtk.HSeparator hseparator2;
		
		private global::Gtk.VBox vbox9;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Entry VehicleTypeEntry;
		
		private global::Gtk.HSeparator hseparator3;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Entry DescriptionEntry;
		
		private global::Gtk.HSeparator hseparator4;
		
		private global::Gtk.VBox vbox10;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Entry PriceEntry;
		
		private global::Gtk.HSeparator hseparator5;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.ComboBox EmployeeComboBox;
		
		private global::Gtk.Button button1;
		
		private global::Gtk.Alignment alignment3;
		
		private global::Gtk.Alignment alignment2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CarRepair.EditRepairWindow
			this.Name = "CarRepair.EditRepairWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Zatvaranje popravka");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CarRepair.EditRepairWindow.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox1.Add (this.alignment5);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment5]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.vbox6.Add (this.alignment4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.alignment4]));
			w2.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Ime i prezime vl.");
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.VehicleOwnerEntry = new global::Gtk.Entry ();
			this.VehicleOwnerEntry.CanFocus = true;
			this.VehicleOwnerEntry.Name = "VehicleOwnerEntry";
			this.VehicleOwnerEntry.IsEditable = false;
			this.VehicleOwnerEntry.InvisibleChar = '●';
			this.hbox2.Add (this.VehicleOwnerEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.VehicleOwnerEntry]));
			w4.Position = 1;
			this.vbox8.Add (this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox8.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hseparator1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Registracija        ");
			this.hbox3.Add (this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.RegistrationEntry = new global::Gtk.Entry ();
			this.RegistrationEntry.CanFocus = true;
			this.RegistrationEntry.Name = "RegistrationEntry";
			this.RegistrationEntry.IsEditable = false;
			this.RegistrationEntry.InvisibleChar = '●';
			this.hbox3.Add (this.RegistrationEntry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.RegistrationEntry]));
			w8.Position = 1;
			this.vbox8.Add (this.hbox3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox3]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox7.Add (this.vbox8);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.vbox8]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox7.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hseparator2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Marka vozila      ");
			this.hbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label3]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.VehicleTypeEntry = new global::Gtk.Entry ();
			this.VehicleTypeEntry.CanFocus = true;
			this.VehicleTypeEntry.Name = "VehicleTypeEntry";
			this.VehicleTypeEntry.IsEditable = false;
			this.VehicleTypeEntry.InvisibleChar = '●';
			this.hbox4.Add (this.VehicleTypeEntry);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.VehicleTypeEntry]));
			w13.Position = 1;
			this.vbox9.Add (this.hbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox4]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.vbox9.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hseparator3]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Opis kvara         ");
			this.hbox5.Add (this.label4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label4]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.DescriptionEntry = new global::Gtk.Entry ();
			this.DescriptionEntry.CanFocus = true;
			this.DescriptionEntry.Name = "DescriptionEntry";
			this.DescriptionEntry.IsEditable = true;
			this.DescriptionEntry.InvisibleChar = '●';
			this.hbox5.Add (this.DescriptionEntry);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.DescriptionEntry]));
			w17.Position = 1;
			this.vbox9.Add (this.hbox5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox5]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox7.Add (this.vbox9);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.vbox9]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator ();
			this.hseparator4.Name = "hseparator4";
			this.vbox7.Add (this.hseparator4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hseparator4]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.vbox10 = new global::Gtk.VBox ();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Cijena                ");
			this.hbox6.Add (this.label5);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label5]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.PriceEntry = new global::Gtk.Entry ();
			this.PriceEntry.CanFocus = true;
			this.PriceEntry.Name = "PriceEntry";
			this.PriceEntry.IsEditable = true;
			this.PriceEntry.InvisibleChar = '●';
			this.hbox6.Add (this.PriceEntry);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.PriceEntry]));
			w22.Position = 1;
			this.vbox10.Add (this.hbox6);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox6]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.hseparator5 = new global::Gtk.HSeparator ();
			this.hseparator5.Name = "hseparator5";
			this.vbox10.Add (this.hseparator5);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hseparator5]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Serviser             ");
			this.hbox7.Add (this.label6);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label6]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.EmployeeComboBox = global::Gtk.ComboBox.NewText ();
			this.EmployeeComboBox.Name = "EmployeeComboBox";
			this.hbox7.Add (this.EmployeeComboBox);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.EmployeeComboBox]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox10.Add (this.hbox7);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox7]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Završi");
			this.vbox10.Add (this.button1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.button1]));
			w28.Position = 3;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox7.Add (this.vbox10);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.vbox10]));
			w29.Position = 4;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox6.Add (this.vbox7);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox7]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.vbox6.Add (this.alignment3);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.alignment3]));
			w31.Position = 2;
			this.hbox1.Add (this.vbox6);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox6]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.hbox1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment2]));
			w33.Position = 2;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 710;
			this.DefaultHeight = 582;
			this.Show ();
			this.button1.Clicked += new global::System.EventHandler (this.onSaveClicked);
		}
	}
}
