
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action OpenFileAction;
	private global::Gtk.Action closeAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action ToolsAction;
	private global::Gtk.Action recordAction;
	private global::Gtk.Action RemoteFXAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action aboutAction;
	private global::Gtk.Action FreeRDPAction;
	private global::Gtk.Action CreateSessionAction;
	private global::Gtk.Action JoinSessionAction;
	private global::Gtk.Action DocumentationAction;
	private global::Gtk.Action ConnectAction;
	private global::Gtk.Action EndSessionAction;
	private global::Gtk.Action LeaveSessionAction;
	private global::Gtk.Action RequestRemoteAccessAction;
	private global::Gtk.Action TerminateRemoteAccessAction;
	private global::Gtk.VBox mainVbox;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox2;
	private global::Gtk.DrawingArea mainDrawingArea;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Label lblParticipants;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView txtParticipants;
	private global::Gtk.Statusbar notificationBar;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, "<Alt>f");
		this.OpenFileAction = new global::Gtk.Action ("OpenFileAction", global::Mono.Unix.Catalog.GetString ("Open File"), null, null);
		this.OpenFileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open");
		w1.Add (this.OpenFileAction, "<Control>o");
		this.closeAction = new global::Gtk.Action ("closeAction", global::Mono.Unix.Catalog.GetString ("Close"), null, null);
		this.closeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close");
		w1.Add (this.closeAction, "<Control>s");
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.quitAction, "<Control>q");
		this.ToolsAction = new global::Gtk.Action ("ToolsAction", global::Mono.Unix.Catalog.GetString ("Tools"), null, null);
		this.ToolsAction.HideIfEmpty = false;
		this.ToolsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Tools");
		w1.Add (this.ToolsAction, "<Alt>t");
		this.recordAction = new global::Gtk.Action ("recordAction", global::Mono.Unix.Catalog.GetString ("Record"), null, null);
		this.recordAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Record");
		w1.Add (this.recordAction, "<Control>r");
		this.RemoteFXAction = new global::Gtk.Action ("RemoteFXAction", global::Mono.Unix.Catalog.GetString ("RemoteFX"), null, null);
		this.RemoteFXAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("RemoteFX");
		w1.Add (this.RemoteFXAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, "<Alt>h");
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.aboutAction, "<Control>a");
		this.FreeRDPAction = new global::Gtk.Action ("FreeRDPAction", global::Mono.Unix.Catalog.GetString ("FreeRDP"), null, null);
		this.FreeRDPAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("FreeRDP");
		w1.Add (this.FreeRDPAction, null);
		this.CreateSessionAction = new global::Gtk.Action ("CreateSessionAction", global::Mono.Unix.Catalog.GetString ("Create Session"), null, null);
		this.CreateSessionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Create Session");
		w1.Add (this.CreateSessionAction, null);
		this.JoinSessionAction = new global::Gtk.Action ("JoinSessionAction", global::Mono.Unix.Catalog.GetString ("Join Session"), null, null);
		this.JoinSessionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Join Session");
		w1.Add (this.JoinSessionAction, null);
		this.DocumentationAction = new global::Gtk.Action ("DocumentationAction", global::Mono.Unix.Catalog.GetString ("Documentation"), null, null);
		this.DocumentationAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Documentation");
		w1.Add (this.DocumentationAction, null);
		this.ConnectAction = new global::Gtk.Action ("ConnectAction", global::Mono.Unix.Catalog.GetString ("Connect"), null, null);
		this.ConnectAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Connect");
		w1.Add (this.ConnectAction, null);
		this.EndSessionAction = new global::Gtk.Action ("EndSessionAction", global::Mono.Unix.Catalog.GetString ("End Session"), null, null);
		this.EndSessionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("End Session");
		w1.Add (this.EndSessionAction, null);
		this.LeaveSessionAction = new global::Gtk.Action ("LeaveSessionAction", global::Mono.Unix.Catalog.GetString ("Leave Session"), null, null);
		this.LeaveSessionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Leave Session");
		w1.Add (this.LeaveSessionAction, null);
		this.RequestRemoteAccessAction = new global::Gtk.Action ("RequestRemoteAccessAction", global::Mono.Unix.Catalog.GetString ("Request Remote Access"), null, null);
		this.RequestRemoteAccessAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Request Screen Control");
		w1.Add (this.RequestRemoteAccessAction, null);
		this.TerminateRemoteAccessAction = new global::Gtk.Action ("TerminateRemoteAccessAction", global::Mono.Unix.Catalog.GetString ("Terminate Remote Access"), null, null);
		this.TerminateRemoteAccessAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Terminate Remote Access");
		w1.Add (this.TerminateRemoteAccessAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Screenary");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainVbox = new global::Gtk.VBox ();
		this.mainVbox.Name = "mainVbox";
		this.mainVbox.Spacing = 6;
		// Container child mainVbox.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenFileAction' action='OpenFileAction'/><menuitem name='ConnectAction' action='ConnectAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='ToolsAction' action='ToolsAction'><menuitem name='CreateSessionAction' action='CreateSessionAction'/><menuitem name='EndSessionAction' action='EndSessionAction'/><menuitem name='JoinSessionAction' action='JoinSessionAction'/><menuitem name='LeaveSessionAction' action='LeaveSessionAction'/><menuitem name='recordAction' action='recordAction'/><menuitem name='RemoteFXAction' action='RemoteFXAction'/><menuitem name='FreeRDPAction' action='FreeRDPAction'/><menuitem name='RequestRemoteAccessAction' action='RequestRemoteAccessAction'/><menuitem name='TerminateRemoteAccessAction' action='TerminateRemoteAccessAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='aboutAction' action='aboutAction'/><menuitem name='DocumentationAction' action='DocumentationAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.CanDefault = true;
		this.menubar1.Events = ((global::Gdk.EventMask)(2));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.mainDrawingArea = new global::Gtk.DrawingArea ();
		this.mainDrawingArea.WidthRequest = 1024;
		this.mainDrawingArea.HeightRequest = 768;
		this.mainDrawingArea.CanFocus = true;
		this.mainDrawingArea.Name = "mainDrawingArea";
		this.hbox2.Add (this.mainDrawingArea);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.mainDrawingArea]));
		w3.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.WidthRequest = 200;
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.lblParticipants = new global::Gtk.Label ();
		this.lblParticipants.Name = "lblParticipants";
		this.lblParticipants.LabelProp = global::Mono.Unix.Catalog.GetString ("Participants");
		this.vbox3.Add (this.lblParticipants);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.lblParticipants]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txtParticipants = new global::Gtk.TextView ();
		this.txtParticipants.Sensitive = false;
		this.txtParticipants.CanFocus = true;
		this.txtParticipants.Name = "txtParticipants";
		this.txtParticipants.Editable = false;
		this.txtParticipants.CursorVisible = false;
		this.txtParticipants.Justification = ((global::Gtk.Justification)(2));
		this.GtkScrolledWindow.Add (this.txtParticipants);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w6.Position = 1;
		this.hbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w8.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.notificationBar = new global::Gtk.Statusbar ();
		this.notificationBar.Name = "notificationBar";
		this.notificationBar.Spacing = 6;
		this.vbox2.Add (this.notificationBar);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notificationBar]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w10.Position = 1;
		this.mainVbox.Add (this.vbox1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.vbox1]));
		w11.Position = 0;
		this.Add (this.mainVbox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1232;
		this.DefaultHeight = 856;
		this.menubar1.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.OpenFileAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.closeAction.Activated += new global::System.EventHandler (this.OnCloseActionActivated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.recordAction.Activated += new global::System.EventHandler (this.OnRecordActionActivated);
		this.RemoteFXAction.Activated += new global::System.EventHandler (this.OnRemoteFXActionActivated);
		this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.FreeRDPAction.Activated += new global::System.EventHandler (this.OnFreeRDPActionActivated);
		this.CreateSessionAction.Activated += new global::System.EventHandler (this.OnCreateSessionActionActivated);
		this.JoinSessionAction.Activated += new global::System.EventHandler (this.OnJoinSessionActionActivated);
		this.ConnectAction.Activated += new global::System.EventHandler (this.OnConnectActionActivated);
		this.EndSessionAction.Activated += new global::System.EventHandler (this.OnEndSessionActionActivated);
		this.LeaveSessionAction.Activated += new global::System.EventHandler (this.OnLeaveSessionActionActivated);
		this.RequestRemoteAccessAction.Activated += new global::System.EventHandler (this.OnRequestRemoteAccessActivated);
		this.TerminateRemoteAccessAction.Activated += new global::System.EventHandler (this.OnTerminateRemoteAccessActivated);
		this.mainDrawingArea.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnMainDrawingAreaExposeEvent);
		this.mainDrawingArea.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnMainDrawingAreaButtonReleaseEvent);
		this.mainDrawingArea.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnMainDrawingAreaButtonPressEvent);
		this.mainDrawingArea.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler (this.OnMainDrawingAreaMotionNotifyEvent);
		this.mainDrawingArea.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnMainDrawingAreaKeyPressEvent);
		this.mainDrawingArea.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnMainDrawingAreaKeyReleaseEvent);
		this.mainDrawingArea.FocusInEvent += new global::Gtk.FocusInEventHandler (this.OnMainDrawingAreaFocusInEvent);
		this.mainDrawingArea.FocusOutEvent += new global::Gtk.FocusOutEventHandler (this.OnMainDrawingAreaFocusOutEvent);
	}
}
