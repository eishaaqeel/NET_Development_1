/*
 * Authour: Eisha Aqeel
 * Date: February 27, 2022
 * Description: This program will calculate the average numbers of reported cases of a disease per week, for 3 regions.
 */

#region USING STATEMENTS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Lab03_Regions_Weekly_Cases
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

        #region DECLARATIONS
        int[,] cases = new int[3, 7];
        const int MIN_CASE = 0;
        const int MAX_CASE = 999999;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// When the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int reg = 0; reg < 3; reg++)
            {
                InitializeArray();
            }
        }

        /// <summary>
        /// When the enter button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            double[] eachAverage = new double[3];

            //loop until all 3 regions boxes have been filled
            for (int region = 0; region < 3; region++)
            {
                int dayCounter = 0;
                // loop until all seven days are filled
                for (int daily = 0; daily < 7; daily++)
                {
                    dayCounter++;
                    if (cases[region, daily] == -999)
                    {
                        // if input is valid then assign that input to the next element in the array
                        if (InputValidation(txtAddCases.Text.Trim(), MIN_CASE, MAX_CASE))
                        {
                            cases[region, daily] = int.Parse(txtAddCases.Text.Trim());
                        }
                        // when a new value is assigned to the array, no more iteration is needed so break this for loop here
                        break;
                    }
                }

                // until all 7 days are filled, don't iteratate through this for loop
                if (dayCounter < 7)
                {
                    break;
                }
                // else all 7 days have inputs,
                else
                {
                    //if region 1
                    if (region == 0)
                    {
                        eachAverage[0] = CalculateAverage(region);
                        lblOutputRegion1Average.Text = "Average: " + eachAverage[0].ToString();
                    }
                    //else if region 2
                    else if (region == 1)
                    {
                        eachAverage[1] = CalculateAverage(region);
                        lblOutputRegion2Average.Text = "Average: " + eachAverage[1].ToString();
                    }
                    //else, it's region 3s average
                    else
                    {
                        eachAverage[2] = CalculateAverage(region);
                        lblOutputRegion3Average.Text = "Average: " + eachAverage[2].ToString();

                        // when all the 3 regions average boxes are filled, write the overall Average
                        double overallAverage = CalculateAverage(3);
                        lblOutputOverallAverage.Text = "Overall Average: " + overallAverage.ToString();

                        //  change the background of that region’s average output control
                        Label[] averagesLabels = { lblOutputRegion1Average, lblOutputRegion2Average, lblOutputRegion3Average };
                        int regionNumber = 0;
                        foreach (Label outLabel in averagesLabels)
                        {
                            //Color the lbl red if it's greater then the overallAverage
                            if (eachAverage[regionNumber] > overallAverage)
                            {
                                outLabel.BackColor = System.Drawing.Color.Red;
                            }
                            // otherwise color the lbl green
                            else if (eachAverage[regionNumber] < overallAverage)
                            {
                                outLabel.BackColor = System.Drawing.Color.Green;
                            }
                            regionNumber++;
                        }
                        // no more input is allowed
                        btnEnter.Enabled = false;
                        txtAddCases.ReadOnly = true;

                    }
                }
            }
            // display the entered daily cases in the region textboxs
            int regionBox = 1;
            txtRegion1.Text = string.Empty;
            for (int daily = 0; daily < 7; daily++)
            {
                if (cases[regionBox - 1, daily] == -999) break;   // if the element is the default value, break iteration
                // append each input for the Region1 textbox, with new line after each input
                txtRegion1.AppendText(cases[regionBox - 1, daily] + "\r\n");
            }
            // Region textbox 2
            regionBox = 2;
            txtRegion2.Text = string.Empty;
            for (int daily = 0; daily < 7; daily++)
            {
                if (cases[regionBox - 1, daily] == -999) break;
                txtRegion2.AppendText(cases[regionBox - 1, daily] + "\r\n");
            }
            // Region textbox 3
            regionBox = 3;
            txtRegion3.Text = string.Empty;
            for (int daily = 0; daily < 7; daily++)
            {
                if (cases[regionBox - 1, daily] == -999) break;
                txtRegion3.AppendText(cases[regionBox - 1, daily] + "\r\n");
            }

            // make input textbox empty and put the cursor to it
            txtAddCases.Text = string.Empty;
            txtAddCases.Select();
        }

        /// <summary>
        /// Reset everything back to default when the Reset button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddCases.Text = string.Empty;
            txtRegion1.Text = string.Empty;
            txtRegion2.Text = string.Empty;
            txtRegion3.Text = string.Empty;
            lblOutputRegion1Average.Text = string.Empty;
            lblOutputRegion2Average.Text = string.Empty;
            lblOutputRegion3Average.Text = string.Empty;
            lblOutputOverallAverage.Text = string.Empty;

            InitializeArray();

            btnEnter.Enabled = true;                
            txtAddCases.ReadOnly = false;
            txtAddCases.Select();
            // restore the background colours of output lables
            lblOutputRegion1Average.BackColor = SystemColors.Control;
            lblOutputRegion2Average.BackColor = SystemColors.Control;
            lblOutputRegion3Average.BackColor = SystemColors.Control;
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Initializing the array
        /// </summary>
        private void InitializeArray()
        {
            for (int reg = 0; reg < 3; reg++)
            {
                for (int day = 0; day < 7; day++)
                {
                    cases[reg, day] = -999;
                }
            }
        }

        /// <summary>
        /// Input Validation
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="MIN_CASE"></param>
        /// <returns></returns>
        private bool InputValidation(string inputValue, int MIN_CASE, int MAX_CASE)
        {
            bool isValid = false;
            int testValue;

            if (int.TryParse(inputValue, out testValue))
            {
                if (testValue < MIN_CASE)
                {
                    MessageBox.Show("The daily case cannot be lower than " + MIN_CASE + "!");
                }
                else if (testValue > MAX_CASE)
                {
                    MessageBox.Show("The daily case must be lower then " + MAX_CASE);
                }
                else { isValid = true; }
            }
            else
            {
                MessageBox.Show("Please input a numeric number.");
            }
            return isValid;
        }

        /// <summary>
        /// Calculate Average
        /// </summary>
        /// <param name="theAverage"></param>
        /// <returns></returns>
        private double CalculateAverage(int theAverage)
        {
            double average;
            double sum = 0;

            // total average calculation
            if (theAverage == 3)
            {
                for (int region = 0; region < 3; region++)
                {
                    for (int daily = 0; daily < 7; daily++)
                    {
                        sum += cases[region, daily];
                    }
                }
                average = Math.Round(sum / 21, 2);
            }
            else
            {
                // regions average calculation
                for (int item = 0; item < 7; item++)
                {
                    sum += cases[theAverage, item];
                }
                average = Math.Round(sum / 7, 2);
            }
            return average;
        }

        #endregion








        

        

    }
}
