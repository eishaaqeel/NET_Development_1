
namespace Lab05_TextEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuFile = new System.Windows.Forms.ToolStripMenuItem();
            menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            txtInput = new System.Windows.Forms.TextBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFile, menuEdit, menuHelp });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(621, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFileNew, menuFileOpen, menuFileSave, menuFileSaveAs, menuFileExit });
            menuFile.Name = "menuFile";
            menuFile.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F;
            menuFile.Size = new System.Drawing.Size(37, 20);
            menuFile.Text = "&File";
            menuFile.ToolTipText = "Click to access the File menu";
            // 
            // menuFileNew
            // 
            menuFileNew.Name = "menuFileNew";
            menuFileNew.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            menuFileNew.Size = new System.Drawing.Size(180, 22);
            menuFileNew.Text = "&New";
            menuFileNew.ToolTipText = "Create a New document ";
            menuFileNew.Click += menuFileNew_Click;
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            menuFileOpen.Size = new System.Drawing.Size(180, 22);
            menuFileOpen.Text = "&Open";
            menuFileOpen.ToolTipText = "Open a document ";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            menuFileSave.Size = new System.Drawing.Size(180, 22);
            menuFileSave.Text = "&Save";
            menuFileSave.ToolTipText = "Save the opened document";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuFileSaveAs
            // 
            menuFileSaveAs.Name = "menuFileSaveAs";
            menuFileSaveAs.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            menuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            menuFileSaveAs.Text = "Save &As";
            menuFileSaveAs.ToolTipText = "Save the document with a new filename ";
            menuFileSaveAs.Click += menuFileSaveAs_Click;
            // 
            // menuFileExit
            // 
            menuFileExit.Name = "menuFileExit";
            menuFileExit.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I;
            menuFileExit.Size = new System.Drawing.Size(180, 22);
            menuFileExit.Text = "Ex&it";
            menuFileExit.ToolTipText = "Exit the application";
            menuFileExit.Click += menuFileExit_Click;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuEditCopy, menuEditCut, menuEditPaste });
            menuEdit.Name = "menuEdit";
            menuEdit.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E;
            menuEdit.Size = new System.Drawing.Size(39, 20);
            menuEdit.Text = "&Edit";
            menuEdit.ToolTipText = "Click to access the Edit menu";
            // 
            // menuEditCopy
            // 
            menuEditCopy.Name = "menuEditCopy";
            menuEditCopy.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            menuEditCopy.Size = new System.Drawing.Size(144, 22);
            menuEditCopy.Text = "&Copy";
            menuEditCopy.ToolTipText = "Copy highlighted text";
            menuEditCopy.Click += menuEditCopy_Click;
            // 
            // menuEditCut
            // 
            menuEditCut.Name = "menuEditCut";
            menuEditCut.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            menuEditCut.Size = new System.Drawing.Size(144, 22);
            menuEditCut.Text = "Cu&t";
            menuEditCut.ToolTipText = "Copy and remove, highlighted text";
            menuEditCut.Click += menuEditCut_Click;
            // 
            // menuEditPaste
            // 
            menuEditPaste.Name = "menuEditPaste";
            menuEditPaste.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            menuEditPaste.Size = new System.Drawing.Size(144, 22);
            menuEditPaste.Text = "&Paste";
            menuEditPaste.ToolTipText = "Insert the copied text";
            menuEditPaste.Click += menuEditPaste_Click;
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuHelpAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H;
            menuHelp.Size = new System.Drawing.Size(44, 20);
            menuHelp.Text = "&Help";
            menuHelp.ToolTipText = "Click to access the Help menu";
            // 
            // menuHelpAbout
            // 
            menuHelpAbout.Name = "menuHelpAbout";
            menuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B;
            menuHelpAbout.Size = new System.Drawing.Size(180, 22);
            menuHelpAbout.Text = "A&bout";
            menuHelpAbout.ToolTipText = "Click to see what this is About";
            menuHelpAbout.Click += menuHelpAbout_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtInput.Location = new System.Drawing.Point(0, 27);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(621, 426);
            txtInput.TabIndex = 2;
            toolTip1.SetToolTip(txtInput, "Click to edit");
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text Files|*.txt";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Text Files|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(621, 450);
            Controls.Add(txtInput);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Text Editor Select a File to Open";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

