/*
 * Author: Eisha Aqeel
 * Date: April 7, 2022
 * Description: This is a Text Editer application using C#.
 * It has menu items and dropdowns to open, save, copy, paste, ect.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab05_TextEditor
{
    public partial class Form1 : Form
    {
        string path = "Text Editor";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit the text editor when Exit is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// when File->New is clicked the screen should clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            // Resets fields to default state.
            txtInput.Clear();
            // Set a default focus.
            txtInput.Focus();
            path = "";
        }

        /// <summary>
        /// when help->About is clicked a messagebox will show up:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi my name is Eisha", "About", MessageBoxButtons.OK);
        }

        /// <summary>
        /// When Open is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult openResult = openFileDialog1.ShowDialog();
            if (openResult == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                StreamReader fileOpen = new StreamReader(path);
                String contents = fileOpen.ReadToEnd();
                fileOpen.Close();
                txtInput.Text = contents;
            }
            this.Text = path;
        }

        /// <summary>
        /// When Save is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            // if nothing is saved
            if (path == string.Empty)
            {
                //do SaveFile, so save as..
                SaveFile();
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(txtInput.Text);
                streamWriter.Close();
            }
        }

        /// <summary>
        /// When Save As is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// When Cut is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtInput.SelectedText);
            SendKeys.Send("{DELETE}");
        }

        /// <summary>
        /// When Copy is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtInput.SelectedText);
        }

        /// <summary>
        /// When Paste is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            txtInput.Paste(Clipboard.GetText());
        }

        /// <summary>
        /// Save File
        /// </summary>
        private void SaveFile()
        {
            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(txtInput.Text);
                streamWriter.Close();
                MessageBox.Show("Save Complete", "Save Confirmation", MessageBoxButtons.OK);

            }
        }

    }
}
