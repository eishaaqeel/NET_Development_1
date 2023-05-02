/*
 * Author: Eisha Aqeel
 * Date:   January 21, 2022
 * Description: This program displays text and asks you a yes/no question.
 * If you click the Yes button another screen pops up and you can click an Ok button
 * which exits the program. The No button will move if you go over it and so you can't 
 * click it. 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //If the user clicks the Yes button, another screen will pop up and display the following text. 
        private void btnYes_Click(object sender, EventArgs e)
        {
            //In the pop up screen, there will be an Ok button, which exits the entire program when clicked.
            MessageBox.Show("Yes, Eisha Aqeel is awesome, aren't they!", "More Awesomeness - Eisha", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }

        // If the user hovers over the No button, the button will move.
        private void btnNo_MouseHover(object sender, EventArgs e)
        {
            btnNo.Left = btnNo.Left - 20;
            btnNo.Top = btnNo.Top - 20;
        }
    }
}
