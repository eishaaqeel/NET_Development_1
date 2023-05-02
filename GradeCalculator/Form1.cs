/* -------------------------------------------------------------------
 * Author:  Eisha Aqeel
 * Date:    February 13, 2022
 * Description: 
 *      This application takes a number grade for 1 to 7 courses 
 *      and then displays the letter grade for each course. When
 *      the user presses calculate it will also calculate the average
 *      grade number and letter for the semester.
 * -------------------------------------------------------------------
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

namespace Lab02_Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region VARIABLE DECALRATIONS
        const int MinGrade = 0;
        const int MaxGrade = 100;
        TextBox[] inputTextboxs;
        Label[] outputLetterGrades;
        #endregion

        #region EVENT HANDLERS
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputTextboxs = new TextBox[] { txtCourse1Grade, txtCourse2Grade, txtCourse3Grade, txtCourse4Grade, txtCourse5Grade, txtCourse6Grade, txtCourse7Grade };
            outputLetterGrades = new Label[] { lblOutputCourse1, lblOutputCourse2, lblOutputCourse3, lblOutputCourse4, lblOutputCourse5, lblOutputCourse6, lblOutputCourse7 };
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double gradeSum = 0;
            int courseNum = 0;
            bool isValid = true;
            for (int item = 0; item < 7; item++)
            {
                //when a textbox is empty, skip it
                if (inputTextboxs[item].Text.Trim() == "") { break; } 
                
                double inputGrade;                  
                if (double.TryParse(inputTextboxs[item].Text.Trim(), out inputGrade))
                {
                    // if the grade is within range
                    if (inputGrade >= MinGrade && inputGrade <= MaxGrade)
                    {
                        // add that grade to the gradeSum
                        gradeSum += double.Parse(inputTextboxs[item].Text.Trim());
                        courseNum++;
                    }
                    else 
                    {
                        lblOutputErrors.Text = "The grade entered for \"Course " + (item + 1) + " must be between " + MinGrade + " and " + MaxGrade;
                        inputTextboxs[item].Select();
                        isValid = false;
                    }
                }
                else
                {
                    lblOutputErrors.Text = "The grade entered for \"Course " + (item + 1) + " is not numeric, Please input a numeric grade.";
                    inputTextboxs[item].Select();
                    isValid = false;
                }

                // if input is valid
                if (courseNum > 0 && isValid == true)
                {
                    // calculate average rounded to 2 digits
                    double average = Math.Round(gradeSum / courseNum, 2);
                    lblOutputAverageGradeNumber.Text = average.ToString();
                    //calculate average letter grade
                    lblOutputAverageLetterGrade.Text = CalculateGrade(average).ToString();
                    // use the method BlockInput defined below to stop more inputs
                    BlockInput();                 
                }

            }
        }

        //When the user leaves each text box after entering something,
        //check if thier input is valid and convert it to a letter grade using the convertGrade method defined below
        private void txtCourse1Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse1Grade, lblOutputCourse1, 1);
        }
        private void txtCourse2Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse2Grade, lblOutputCourse2, 2);
        }
        private void txtCourse3Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse3Grade, lblOutputCourse3, 3);
        }
        private void txtCourse4Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse4Grade, lblOutputCourse4, 4);
        }
        private void txtCourse5Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse5Grade, lblOutputCourse5, 5);
        }
        private void txtCourse6Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse6Grade, lblOutputCourse6, 6);
        }
        private void txtCourse7Grade_Leave(object sender, EventArgs e)
        {
            ConvertGrade(txtCourse7Grade, lblOutputCourse7, 7);
        }

        #endregion

        #region METHODS
        /// <summary>
        /// A method to Convert the Number grade to Letter 
        /// by Validating and Calculating what letter Grade it would convert to
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="lblbox"></param>
        /// <param name="numberGrade"></param>
        private void ConvertGrade(TextBox txtbox, Label lblbox, int numberGrade)
        {
            int validation = ValidCheck(txtbox.Text.Trim(), MinGrade, MaxGrade);
            // don't need to do anything when the input textbox is empty
            if (validation == -1) { }
            //using validCheck, 1 means not numeric
            else if (validation == 1)
            {
                lblOutputErrors.Text = "The grade entered for \"Course " + numberGrade + " is not numeric, Please input a numeric grade.";
                // because the input is not valid, put the focus on the textbox, and clear the letter grade output
                txtbox.Select();
                lblbox.Text = string.Empty;
            }
            //using validCheck, 2 means out of range
            else if (validation == 2)
            {
                lblOutputErrors.Text = "The grade entered for \"Course " + numberGrade + " must be between " + MinGrade + " and " + MaxGrade;
                // because the input is not valid, put the focus on the textbox, and clear the letter grade output
                txtbox.Select();
                lblbox.Text = string.Empty;
            }
            //else it should be valid, so CalculateGrade
            else
            {
                lblbox.Text = CalculateGrade(double.Parse(txtbox.Text.Trim()));
                // empty any error message from before
                lblOutputErrors.Text = string.Empty;
            }

        }

        /// <summary>
        /// Validation Ckeck
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>retVal</returns>
        private int ValidCheck(string inputValue, int minValue, int maxValue)
        {
            int retVal = 0;
            // when input textbox is empty, return -1
            if (inputValue == "") { retVal = -1; }
            else
            {
                double temp;
                if (double.TryParse(inputValue, out temp))
                {
                    if (!(IsInRange(temp, minValue, maxValue)))
                    // 2 means out of range
                    { retVal = 2; }
                }
                else
                {
                    // 1 means not a numeric
                    retVal = 1;
                }
            }
            return retVal;
        }
        /// <summary>
        /// Check if input is in range
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>(inputValue >= minValue && inputValue <= maxValue)</returns>
        private bool IsInRange(double inputValue, int minValue, int maxValue)
        {
            return (inputValue >= minValue && inputValue <= maxValue);
        }

        private string CalculateGrade(double numberGrade)
        {
            string letterGrade = "";
            if (numberGrade >= 90) { letterGrade = "A+"; }
            else if (numberGrade >= 82) { letterGrade = "A"; }
            else if (numberGrade >= 80) { letterGrade = "A-"; }
            else if (numberGrade >= 78) { letterGrade = "B+"; }
            else if (numberGrade >= 72) { letterGrade = "B"; }
            else if (numberGrade >= 70) { letterGrade = "B-"; }
            else if (numberGrade >= 68) { letterGrade = "C+"; }
            else if (numberGrade >= 62) { letterGrade = "C"; }
            else if (numberGrade >= 60) { letterGrade = "C-"; }
            else if (numberGrade >= 58) { letterGrade = "D+"; }
            else if (numberGrade >= 52) { letterGrade = "D"; }
            else if (numberGrade >= 50) { letterGrade = "D-"; }
            else { letterGrade = "F"; }

            return letterGrade;
        }

        /// <summary>
        /// Block user from entering Input
        /// </summary>
        private void BlockInput()
        {
            buttonCalculate.Enabled = false;       
            txtCourse1Grade.ReadOnly = true;
            txtCourse2Grade.ReadOnly = true;
            txtCourse3Grade.ReadOnly = true;
            txtCourse4Grade.ReadOnly = true;
            txtCourse5Grade.ReadOnly = true;
            txtCourse6Grade.ReadOnly = true;
            txtCourse7Grade.ReadOnly = true;
        }

        /// <summary>
        /// Set everything back to default
        /// </summary>
        private void SetDefaults()
        {
            buttonCalculate.Enabled = true;
            txtCourse1Grade.ReadOnly = false;
            txtCourse2Grade.ReadOnly = false;
            txtCourse3Grade.ReadOnly = false;
            txtCourse4Grade.ReadOnly = false;
            txtCourse5Grade.ReadOnly = false;
            txtCourse6Grade.ReadOnly = false;
            txtCourse7Grade.ReadOnly = false;

            txtCourse1Grade.Clear();
            txtCourse2Grade.Clear();
            txtCourse3Grade.Clear();
            txtCourse4Grade.Clear();
            txtCourse5Grade.Clear();
            txtCourse6Grade.Clear();
            txtCourse7Grade.Clear();
            lblOutputCourse1.Text = "";
            lblOutputCourse2.Text = "";
            lblOutputCourse3.Text = "";
            lblOutputCourse4.Text = "";
            lblOutputCourse5.Text = "";
            lblOutputCourse6.Text = "";
            lblOutputCourse7.Text = "";
            lblOutputAverageGradeNumber.Text = "";
            lblOutputAverageLetterGrade.Text = "";
            //Set the cursor to the first course
            txtCourse1Grade.Focus();
        }
        #endregion

    }
}