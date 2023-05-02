
/*
 * Authors : Hongju Shin & Eisha Aqeel
 * Date: 27 Jan 2022
 * Description: App calculating the weekly average from the user's input by the week
 */

#region Using section
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

# endregion

namespace Final_Project
{
    public partial class FormWeeklyCases : Form
    {
        public FormWeeklyCases()
        {
            InitializeComponent();
        }


        #region execute when opening the app

        /// <summary>
        /// excute when windows open : Day lable to one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormWeeklyCases_Load(object sender, EventArgs e)
        {
            lblDays.Text = "Day 1"; 
        }
        #endregion


        #region Main button events

        /// <summary>
        /// enter the each number of case of each day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int input;
            // validation of input
            if (int.TryParse(txtInput.Text, out input) && input >= 0)
            {
                    lbxEntry.Items.Add(input);  // move to entry list box
                    txtInput.Clear();           // clear the input text box
                    txtInput.Focus();           // cursor to input text box
                    calculationAndCount();      // call the custom function
            }
            else 
            {
                MessageBox.Show("Input only a whole number with zero or bigger");
            }
        }

        /// <summary>
        /// reset and cleaar all to default 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lbxEntry.Items.Clear();
            lblOutput.Text = string.Empty;
            txtInput.Focus();

            txtInput.ReadOnly = false;
            btnEnter.Enabled = true;
        }

        /// <summary>
        /// exit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Exit Confirmation",
    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }






        #endregion

        #region Custom Methods

        /// <summary>
        /// when inut a number, count the total and calculate averate when it is 7
        /// </summary>
        private void calculationAndCount()
        {
            int days = 0;                               // initialize
            days = lbxEntry.Items.Count + 1;            // calculate the input day, counting the entries
            if (days <= 7)                              // if the entries are not yet 7
            {
                lblDays.Text = "Day " + days.ToString();  // display which day I am inputing
            }

            if (days > 7)                               // if the entries reach to 7 
            {
                double sum = 0.0;
                double average = 0;
                for (int i = 0; i < 7; i++)            // iterate 7 times
                {
                     sum += (int)lbxEntry.Items[i];    // add total
                }

                average = sum / lbxEntry.Items.Count;   // calculate average

                lblOutput.Text = "Average per day: " + Math.Round(average,2);

                // here freeze the enter button, no more entry
                // input txtbox into read only

                txtInput.ReadOnly = true;               // disable more input
                btnEnter.Enabled = false;
  


            }
        }




        


  


        #endregion


    }
}