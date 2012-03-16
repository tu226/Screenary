
// This file has been generated by the GUI designer. Do not modify.
namespace Screenary.Client
{
	public partial class WelcomeDialog
	{
		private global::Gtk.Label label1;
		private global::Gtk.Button buttonSender;
		private global::Gtk.Button buttonReceiver;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Screenary.Client.WelcomeDialog
			this.Name = "Screenary.Client.WelcomeDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Welcome to Screenary!");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Screenary.Client.WelcomeDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Would you like to use the application as a sender or receiver?");
			w1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(16));
			// Internal child Screenary.Client.WelcomeDialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonSender = new global::Gtk.Button ();
			this.buttonSender.CanDefault = true;
			this.buttonSender.CanFocus = true;
			this.buttonSender.Name = "buttonSender";
			this.buttonSender.UseUnderline = true;
			this.buttonSender.Label = global::Mono.Unix.Catalog.GetString ("Sender");
			this.AddActionWidget (this.buttonSender, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonSender]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonReceiver = new global::Gtk.Button ();
			this.buttonReceiver.CanDefault = true;
			this.buttonReceiver.CanFocus = true;
			this.buttonReceiver.Name = "buttonReceiver";
			this.buttonReceiver.UseUnderline = true;
			this.buttonReceiver.Label = global::Mono.Unix.Catalog.GetString ("Receiver");
			this.AddActionWidget (this.buttonReceiver, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonReceiver]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 410;
			this.DefaultHeight = 133;
			this.Show ();
			this.buttonSender.Clicked += new global::System.EventHandler (this.OnButtonSenderClicked);
			this.buttonReceiver.Clicked += new global::System.EventHandler (this.OnButtonReceiverClicked);
		}
	}
}
