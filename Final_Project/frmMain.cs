#region Info
/* Authors : Hongju Shin & Eisha Aqeel
 * Group:  Group 1
 * Date: 17 Apr 2022
 * Subject: Final Project
 * Purpose: Consolidation of the projects
 */
#endregion


using System;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        #region initiallization 
        
        String path = "";
        public frmMain()
        {
            InitializeComponent();
           
        }
        #endregion

        #region file control
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            TextEditor frm = new TextEditor();
            frm.MdiParent = this;
            frm.Text = "Text Editor " + childFormNumber++;
            frm.Show();
            frm.Focus();
            frm.txtMain.Clear();
            path = "";
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (path == string.Empty)         // if there is no saved 
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                }
            }                                   // the same as "save as"
            else                                // or, save to the current file
            {
                TextEditor frm = new TextEditor();
                StreamWriter sw = new StreamWriter(path);
                sw.Write(frm.txtMain.Text);
                sw.Close();
            }
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }

        }
        #endregion

        #region event handlers
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuWindowsCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuWindowsTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuWindowsTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuWindowsCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

        }

        private void menuWindowsWeeklyCases_Click(object sender, EventArgs e)
        {
            WeeklyCases frm = new WeeklyCases();

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuWindowsContactTracer_Click(object sender, EventArgs e)
        {
            ContactTracer frm = new ContactTracer();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuWindowsTextEditor_Click(object sender, EventArgs e)
        {
            TextEditor frm = new TextEditor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
            //this.menuFile.Visible = false;
            //this.menuEdit.Visible = false;
            //this.menuHelp.Visible = false;
        }

        private void menuWindowsGPAGrade_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuWindowsAwesomeness_Click(object sender, EventArgs e)
        {
            Awesomeness frm = new Awesomeness();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuWindowsCustomClass_Click(object sender, EventArgs e)
        {
            ShowCars frm = new ShowCars();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuWindowsCustomerEntry_Click(object sender, EventArgs e)
        {
            formCustomerEntry frm = new formCustomerEntry();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        #endregion




    }
}
