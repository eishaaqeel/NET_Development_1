
namespace Final_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsWeeklyCases = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsContactTracer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsTextEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsGPAGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsAwesomeness = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsCustomClass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsCustomerEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuWindows,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.menuWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(983, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator3,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator4,
            this.menuFileClose,
            this.toolStripSeparator5,
            this.menuFileExit});
            this.menuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Click to access the File menu";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(196, 38);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Create a New document ";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(196, 38);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Open a document";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(196, 38);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Save the opened document";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(196, 38);
            this.menuFileSaveAs.Text = "Sa&ve As";
            this.menuFileSaveAs.ToolTipText = "Save the document with a new filename ";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuFileClose.Size = new System.Drawing.Size(196, 38);
            this.menuFileClose.Text = "C&lose";
            this.menuFileClose.ToolTipText = "Close the opened document";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuFileExit.Size = new System.Drawing.Size(196, 38);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Exit the application";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripSeparator7,
            this.menuEditSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Click to access the Edit menu";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(193, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuEditCut.Size = new System.Drawing.Size(196, 38);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Copy and remove, highlighted text";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(196, 38);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Copy the text you highlighted";
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuEditPaste.Size = new System.Drawing.Size(196, 38);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Insert the copied text";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(193, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuEditSelectAll.Size = new System.Drawing.Size(196, 38);
            this.menuEditSelectAll.Text = "Select &All";
            this.menuEditSelectAll.ToolTipText = "Select all the text in the opened document";
            // 
            // menuWindows
            // 
            this.menuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowsCascade,
            this.menuWindowsTileVertical,
            this.menuWindowsTileHorizontal,
            this.menuWindowsCloseAll,
            this.menuWindowsWeeklyCases,
            this.menuWindowsContactTracer,
            this.menuWindowsTextEditor,
            this.menuWindowsGPAGrade,
            this.menuWindowsAwesomeness,
            this.menuWindowsCustomClass,
            this.menuWindowsCustomerEntry});
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(68, 20);
            this.menuWindows.Text = "&Windows";
            this.menuWindows.ToolTipText = "Click to access the Windows menu";
            // 
            // menuWindowsCascade
            // 
            this.menuWindowsCascade.Name = "menuWindowsCascade";
            this.menuWindowsCascade.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsCascade.Text = "&Cascade";
            this.menuWindowsCascade.ToolTipText = "Arrange all open application here in a cascade";
            this.menuWindowsCascade.Click += new System.EventHandler(this.menuWindowsCascade_Click);
            // 
            // menuWindowsTileVertical
            // 
            this.menuWindowsTileVertical.Name = "menuWindowsTileVertical";
            this.menuWindowsTileVertical.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsTileVertical.Text = "Tile &Vertical";
            this.menuWindowsTileVertical.ToolTipText = "Arrange all open MDI child forms in a vertical pattern";
            this.menuWindowsTileVertical.Click += new System.EventHandler(this.menuWindowsTileVertical_Click);
            // 
            // menuWindowsTileHorizontal
            // 
            this.menuWindowsTileHorizontal.Name = "menuWindowsTileHorizontal";
            this.menuWindowsTileHorizontal.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsTileHorizontal.Text = "Tile &Horizontal";
            this.menuWindowsTileHorizontal.ToolTipText = "Arrange all open MDI child forms in a horizontal pattern";
            this.menuWindowsTileHorizontal.Click += new System.EventHandler(this.menuWindowsTileHorizontal_Click);
            // 
            // menuWindowsCloseAll
            // 
            this.menuWindowsCloseAll.Name = "menuWindowsCloseAll";
            this.menuWindowsCloseAll.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsCloseAll.Text = "C&lose All";
            this.menuWindowsCloseAll.ToolTipText = "Close all open MDI child applications";
            this.menuWindowsCloseAll.Click += new System.EventHandler(this.menuWindowsCloseAll_Click);
            // 
            // menuWindowsWeeklyCases
            // 
            this.menuWindowsWeeklyCases.Name = "menuWindowsWeeklyCases";
            this.menuWindowsWeeklyCases.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsWeeklyCases.Text = "Open W&eekly Cases";
            this.menuWindowsWeeklyCases.ToolTipText = "Open the \"Weekly Cases\" application";
            this.menuWindowsWeeklyCases.Click += new System.EventHandler(this.menuWindowsWeeklyCases_Click);
            // 
            // menuWindowsContactTracer
            // 
            this.menuWindowsContactTracer.Name = "menuWindowsContactTracer";
            this.menuWindowsContactTracer.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsContactTracer.Text = "Open Contact &Tracer";
            this.menuWindowsContactTracer.ToolTipText = "Open the \"Contact Tracer\" application";
            this.menuWindowsContactTracer.Click += new System.EventHandler(this.menuWindowsContactTracer_Click);
            // 
            // menuWindowsTextEditor
            // 
            this.menuWindowsTextEditor.Name = "menuWindowsTextEditor";
            this.menuWindowsTextEditor.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsTextEditor.Text = "Open Te&xt Editor";
            this.menuWindowsTextEditor.ToolTipText = "Open the \"Text Editor\" application";
            this.menuWindowsTextEditor.Click += new System.EventHandler(this.menuWindowsTextEditor_Click);
            // 
            // menuWindowsGPAGrade
            // 
            this.menuWindowsGPAGrade.Name = "menuWindowsGPAGrade";
            this.menuWindowsGPAGrade.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsGPAGrade.Text = "Open &GPA Grade";
            this.menuWindowsGPAGrade.ToolTipText = "Open the \"GPA Grade\" application";
            this.menuWindowsGPAGrade.Click += new System.EventHandler(this.menuWindowsGPAGrade_Click);
            // 
            // menuWindowsAwesomeness
            // 
            this.menuWindowsAwesomeness.Name = "menuWindowsAwesomeness";
            this.menuWindowsAwesomeness.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsAwesomeness.Text = "ICE 1 &Awesomeness";
            this.menuWindowsAwesomeness.ToolTipText = "Open the \"Awesomeness\" application";
            this.menuWindowsAwesomeness.Click += new System.EventHandler(this.menuWindowsAwesomeness_Click);
            // 
            // menuWindowsCustomClass
            // 
            this.menuWindowsCustomClass.Name = "menuWindowsCustomClass";
            this.menuWindowsCustomClass.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsCustomClass.Text = "ICE 4 C&ustom Class Editor";
            this.menuWindowsCustomClass.ToolTipText = "Open the \"Custom Class Editor\" application";
            this.menuWindowsCustomClass.Click += new System.EventHandler(this.menuWindowsCustomClass_Click);
            // 
            // menuWindowsCustomerEntry
            // 
            this.menuWindowsCustomerEntry.Name = "menuWindowsCustomerEntry";
            this.menuWindowsCustomerEntry.Size = new System.Drawing.Size(209, 22);
            this.menuWindowsCustomerEntry.Text = "ICE 5 Cu&stomer Entry";
            this.menuWindowsCustomerEntry.ToolTipText = "Open the \"Customer Entry\" application";
            this.menuWindowsCustomerEntry.Click += new System.EventHandler(this.menuWindowsCustomerEntry_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Click to access the Help menu";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(104, 6);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.ToolTipText = "Click to see what this is About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 630);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(983, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 652);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI App for NETD2022";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsCloseAll;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsWeeklyCases;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsContactTracer;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsTextEditor;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsGPAGrade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsAwesomeness;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsCustomClass;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsCustomerEntry;
    }
}



