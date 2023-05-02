/*
 * Authour: Eisha Aqeel
 * Date: January 30, 2022
 * Description: This program will calculate the average numbers of reported cases of a disease per week.
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

namespace Lab01_Average_Weekly_Cases
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Main form  constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDays.Text = "Day 1";
        }

        /// <summary>
        /// Take the number from the textbox and add it to the list box. Can only be done 7 times and then you have to reset to do it agian.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int input;
            // validation of input
            if (int.TryParse(txtAddCases.Text, out input) && input >= 0)
            {
                // move to list box
                lbxCasesEntered.Items.Add(input);
                // clear then put cursor on the input box
                txtAddCases.Clear();           
                txtAddCases.Focus();
                // call calculate function defined befow
                calculate();
            }
            else
            {
                MessageBox.Show("Input only a whole number with zero or bigger");
            }
        }

        /// <summary>
        /// Count the total number of inputs and calculate average when day is 7
        /// </summary>
        private void calculate()
        {
            int days = 0;
            days = lbxCasesEntered.Items.Count + 1;
            
            if (days <= 7)                              
            {
                // display which day or entry the user is currently inputing for
                lblDays.Text = "Day " + days.ToString();
            }

            // if entries reach to 7
            if (days > 7)                               
            {
                double sum = 0.0;
                double average = 0;
                // iterate 7 times
                for (int i = 0; i < 7; i++)            
                {
                    // add to sum
                    sum += (int)lbxCasesEntered.Items[i];    
                }

                // calculate average
                average = sum / lbxCasesEntered.Items.Count;   

                lblOutput.Text = "Average per day: " + Math.Round(average, 2);

                // freeze the enter button because only 7 entries are allowed
                btnEnter.Enabled = false;          

            }
        }

        /// <summary>
        /// Resets all form items to their default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
            //if the reset button is clicked, it will also re-enable the enter button
            btnEnter.Enabled = true;
        }

        /// <summary>
        /// Exits the application, based on a confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Sets the entire form to its default values
        /// </summary>
        private void SetDefaults()
        {
            // Clear all lists, labels, and textboxes
            txtAddCases.Clear();
            lbxCasesEntered.Items.Clear();
            lblOutput.Text = String.Empty;

            // Set the cursor to the starting position
            txtAddCases.Focus();
        }

        /// <summary>
        /// Validation: only allows whole, positve numbers to be entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddCases_KeyPress(object sender, KeyPressEventArgs e)
        {
            //I got the following three lines of code from a youtube video. So cridits to "C# Tutorials-How to make TextBox accept only Numbers"
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
