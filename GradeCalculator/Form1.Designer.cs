
namespace Lab02_Grade_Calculator
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
            lblCourse1 = new System.Windows.Forms.Label();
            txtCourse1Grade = new System.Windows.Forms.TextBox();
            lblOutputCourse1 = new System.Windows.Forms.Label();
            lblOutputCourse2 = new System.Windows.Forms.Label();
            txtCourse2Grade = new System.Windows.Forms.TextBox();
            lblCourse2 = new System.Windows.Forms.Label();
            lblOutputCourse3 = new System.Windows.Forms.Label();
            txtCourse3Grade = new System.Windows.Forms.TextBox();
            lblCourse3 = new System.Windows.Forms.Label();
            lblOutputCourse4 = new System.Windows.Forms.Label();
            txtCourse4Grade = new System.Windows.Forms.TextBox();
            lblCourse4 = new System.Windows.Forms.Label();
            lblOutputCourse5 = new System.Windows.Forms.Label();
            txtCourse5Grade = new System.Windows.Forms.TextBox();
            lblCourse5 = new System.Windows.Forms.Label();
            lblOutputCourse6 = new System.Windows.Forms.Label();
            txtCourse6Grade = new System.Windows.Forms.TextBox();
            lblCourse6 = new System.Windows.Forms.Label();
            lblOutputCourse7 = new System.Windows.Forms.Label();
            txtCourse7Grade = new System.Windows.Forms.TextBox();
            lblCourse7 = new System.Windows.Forms.Label();
            lblOutputAverageGradeNumber = new System.Windows.Forms.Label();
            lblSemester = new System.Windows.Forms.Label();
            lblOutputAverageLetterGrade = new System.Windows.Forms.Label();
            lblOutputErrors = new System.Windows.Forms.Label();
            buttonCalculate = new System.Windows.Forms.Button();
            buttonReset = new System.Windows.Forms.Button();
            buttonExit = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // lblCourse1
            // 
            lblCourse1.AutoSize = true;
            lblCourse1.Location = new System.Drawing.Point(13, 13);
            lblCourse1.Name = "lblCourse1";
            lblCourse1.Size = new System.Drawing.Size(56, 15);
            lblCourse1.TabIndex = 0;
            lblCourse1.Text = "Course &1:";
            // 
            // txtCourse1Grade
            // 
            txtCourse1Grade.Location = new System.Drawing.Point(75, 10);
            txtCourse1Grade.Name = "txtCourse1Grade";
            txtCourse1Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse1Grade.TabIndex = 1;
            txtCourse1Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse1Grade, "Enter a number grade for course 1");
            txtCourse1Grade.Leave += txtCourse1Grade_Leave;
            // 
            // lblOutputCourse1
            // 
            lblOutputCourse1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse1.Location = new System.Drawing.Point(181, 10);
            lblOutputCourse1.Name = "lblOutputCourse1";
            lblOutputCourse1.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse1.TabIndex = 2;
            lblOutputCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse1, "This is the letter grade for course 1");
            // 
            // lblOutputCourse2
            // 
            lblOutputCourse2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse2.Location = new System.Drawing.Point(181, 39);
            lblOutputCourse2.Name = "lblOutputCourse2";
            lblOutputCourse2.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse2.TabIndex = 5;
            lblOutputCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse2, "This is the letter grade for course 2");
            // 
            // txtCourse2Grade
            // 
            txtCourse2Grade.Location = new System.Drawing.Point(75, 39);
            txtCourse2Grade.Name = "txtCourse2Grade";
            txtCourse2Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse2Grade.TabIndex = 4;
            txtCourse2Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse2Grade, "Enter a number grade for course 2");
            txtCourse2Grade.Leave += txtCourse2Grade_Leave;
            // 
            // lblCourse2
            // 
            lblCourse2.AutoSize = true;
            lblCourse2.Location = new System.Drawing.Point(13, 42);
            lblCourse2.Name = "lblCourse2";
            lblCourse2.Size = new System.Drawing.Size(56, 15);
            lblCourse2.TabIndex = 3;
            lblCourse2.Text = "Course &2:";
            // 
            // lblOutputCourse3
            // 
            lblOutputCourse3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse3.Location = new System.Drawing.Point(181, 68);
            lblOutputCourse3.Name = "lblOutputCourse3";
            lblOutputCourse3.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse3.TabIndex = 8;
            lblOutputCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse3, "This is the letter grade for course 3");
            // 
            // txtCourse3Grade
            // 
            txtCourse3Grade.Location = new System.Drawing.Point(75, 68);
            txtCourse3Grade.Name = "txtCourse3Grade";
            txtCourse3Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse3Grade.TabIndex = 7;
            txtCourse3Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse3Grade, "Enter a number grade for course 3");
            txtCourse3Grade.Leave += txtCourse3Grade_Leave;
            // 
            // lblCourse3
            // 
            lblCourse3.AutoSize = true;
            lblCourse3.Location = new System.Drawing.Point(13, 71);
            lblCourse3.Name = "lblCourse3";
            lblCourse3.Size = new System.Drawing.Size(56, 15);
            lblCourse3.TabIndex = 6;
            lblCourse3.Text = "Course &3:";
            // 
            // lblOutputCourse4
            // 
            lblOutputCourse4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse4.Location = new System.Drawing.Point(181, 97);
            lblOutputCourse4.Name = "lblOutputCourse4";
            lblOutputCourse4.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse4.TabIndex = 11;
            lblOutputCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse4, "This is the letter grade for course 4");
            // 
            // txtCourse4Grade
            // 
            txtCourse4Grade.Location = new System.Drawing.Point(75, 97);
            txtCourse4Grade.Name = "txtCourse4Grade";
            txtCourse4Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse4Grade.TabIndex = 10;
            txtCourse4Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse4Grade, "Enter a number grade for course 4");
            txtCourse4Grade.Leave += txtCourse4Grade_Leave;
            // 
            // lblCourse4
            // 
            lblCourse4.AutoSize = true;
            lblCourse4.Location = new System.Drawing.Point(13, 100);
            lblCourse4.Name = "lblCourse4";
            lblCourse4.Size = new System.Drawing.Size(56, 15);
            lblCourse4.TabIndex = 9;
            lblCourse4.Text = "Course &4:";
            // 
            // lblOutputCourse5
            // 
            lblOutputCourse5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse5.Location = new System.Drawing.Point(181, 126);
            lblOutputCourse5.Name = "lblOutputCourse5";
            lblOutputCourse5.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse5.TabIndex = 14;
            lblOutputCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse5, "This is the letter grade for course 5");
            // 
            // txtCourse5Grade
            // 
            txtCourse5Grade.Location = new System.Drawing.Point(75, 126);
            txtCourse5Grade.Name = "txtCourse5Grade";
            txtCourse5Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse5Grade.TabIndex = 13;
            txtCourse5Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse5Grade, "Enter a number grade for course 5");
            txtCourse5Grade.Leave += txtCourse5Grade_Leave;
            // 
            // lblCourse5
            // 
            lblCourse5.AutoSize = true;
            lblCourse5.Location = new System.Drawing.Point(13, 129);
            lblCourse5.Name = "lblCourse5";
            lblCourse5.Size = new System.Drawing.Size(56, 15);
            lblCourse5.TabIndex = 12;
            lblCourse5.Text = "Course &5:";
            // 
            // lblOutputCourse6
            // 
            lblOutputCourse6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse6.Location = new System.Drawing.Point(181, 155);
            lblOutputCourse6.Name = "lblOutputCourse6";
            lblOutputCourse6.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse6.TabIndex = 17;
            lblOutputCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse6, "This is the letter grade for course 6");
            // 
            // txtCourse6Grade
            // 
            txtCourse6Grade.Location = new System.Drawing.Point(75, 155);
            txtCourse6Grade.Name = "txtCourse6Grade";
            txtCourse6Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse6Grade.TabIndex = 16;
            txtCourse6Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse6Grade, "Enter a number grade for course 6");
            txtCourse6Grade.Leave += txtCourse6Grade_Leave;
            // 
            // lblCourse6
            // 
            lblCourse6.AutoSize = true;
            lblCourse6.Location = new System.Drawing.Point(13, 158);
            lblCourse6.Name = "lblCourse6";
            lblCourse6.Size = new System.Drawing.Size(56, 15);
            lblCourse6.TabIndex = 15;
            lblCourse6.Text = "Course &6:";
            // 
            // lblOutputCourse7
            // 
            lblOutputCourse7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputCourse7.Location = new System.Drawing.Point(181, 184);
            lblOutputCourse7.Name = "lblOutputCourse7";
            lblOutputCourse7.Size = new System.Drawing.Size(100, 24);
            lblOutputCourse7.TabIndex = 20;
            lblOutputCourse7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputCourse7, "This is the letter grade for course 7");
            // 
            // txtCourse7Grade
            // 
            txtCourse7Grade.Location = new System.Drawing.Point(75, 184);
            txtCourse7Grade.Name = "txtCourse7Grade";
            txtCourse7Grade.Size = new System.Drawing.Size(100, 23);
            txtCourse7Grade.TabIndex = 19;
            txtCourse7Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip1.SetToolTip(txtCourse7Grade, "Enter a number grade for course 7");
            txtCourse7Grade.Leave += txtCourse7Grade_Leave;
            // 
            // lblCourse7
            // 
            lblCourse7.AutoSize = true;
            lblCourse7.Location = new System.Drawing.Point(13, 187);
            lblCourse7.Name = "lblCourse7";
            lblCourse7.Size = new System.Drawing.Size(56, 15);
            lblCourse7.TabIndex = 18;
            lblCourse7.Text = "Course &7:";
            // 
            // lblOutputAverageGradeNumber
            // 
            lblOutputAverageGradeNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputAverageGradeNumber.Location = new System.Drawing.Point(77, 230);
            lblOutputAverageGradeNumber.Name = "lblOutputAverageGradeNumber";
            lblOutputAverageGradeNumber.Size = new System.Drawing.Size(100, 24);
            lblOutputAverageGradeNumber.TabIndex = 23;
            lblOutputAverageGradeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputAverageGradeNumber, "This is the average grade this semester");
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Location = new System.Drawing.Point(13, 235);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new System.Drawing.Size(58, 15);
            lblSemester.TabIndex = 21;
            lblSemester.Text = "&Semester:";
            // 
            // lblOutputAverageLetterGrade
            // 
            lblOutputAverageLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputAverageLetterGrade.Location = new System.Drawing.Point(183, 230);
            lblOutputAverageLetterGrade.Name = "lblOutputAverageLetterGrade";
            lblOutputAverageLetterGrade.Size = new System.Drawing.Size(100, 24);
            lblOutputAverageLetterGrade.TabIndex = 24;
            lblOutputAverageLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputAverageLetterGrade, "This is the letter grade for your average grade this semester");
            // 
            // lblOutputErrors
            // 
            lblOutputErrors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutputErrors.Location = new System.Drawing.Point(13, 269);
            lblOutputErrors.Name = "lblOutputErrors";
            lblOutputErrors.Size = new System.Drawing.Size(268, 89);
            lblOutputErrors.TabIndex = 25;
            toolTip1.SetToolTip(lblOutputErrors, "This is to display error messages");
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new System.Drawing.Point(22, 368);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new System.Drawing.Size(88, 31);
            buttonCalculate.TabIndex = 26;
            buttonCalculate.Text = "&Calculcate";
            toolTip1.SetToolTip(buttonCalculate, "Calculate the letter grade, and the average grade for the course(s) of this semester");
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new System.Drawing.Point(114, 368);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(75, 31);
            buttonReset.TabIndex = 27;
            buttonReset.Text = "&Reset";
            toolTip1.SetToolTip(buttonReset, "Reset the form to its default values");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new System.Drawing.Point(195, 368);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(75, 31);
            buttonExit.TabIndex = 28;
            buttonExit.Text = "&Exit";
            toolTip1.SetToolTip(buttonExit, "Exit the application");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonReset;
            ClientSize = new System.Drawing.Size(297, 411);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalculate);
            Controls.Add(lblOutputErrors);
            Controls.Add(lblOutputAverageLetterGrade);
            Controls.Add(lblOutputAverageGradeNumber);
            Controls.Add(lblSemester);
            Controls.Add(lblOutputCourse7);
            Controls.Add(txtCourse7Grade);
            Controls.Add(lblCourse7);
            Controls.Add(lblOutputCourse6);
            Controls.Add(txtCourse6Grade);
            Controls.Add(lblCourse6);
            Controls.Add(lblOutputCourse5);
            Controls.Add(txtCourse5Grade);
            Controls.Add(lblCourse5);
            Controls.Add(lblOutputCourse4);
            Controls.Add(txtCourse4Grade);
            Controls.Add(lblCourse4);
            Controls.Add(lblOutputCourse3);
            Controls.Add(txtCourse3Grade);
            Controls.Add(lblCourse3);
            Controls.Add(lblOutputCourse2);
            Controls.Add(txtCourse2Grade);
            Controls.Add(lblCourse2);
            Controls.Add(lblOutputCourse1);
            Controls.Add(txtCourse1Grade);
            Controls.Add(lblCourse1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(313, 450);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eisha's Grade Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.TextBox txtCourse1Grade;
        private System.Windows.Forms.Label lblOutputCourse1;
        private System.Windows.Forms.Label lblOutputCourse2;
        private System.Windows.Forms.TextBox txtCourse2Grade;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblOutputCourse3;
        private System.Windows.Forms.TextBox txtCourse3Grade;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblOutputCourse4;
        private System.Windows.Forms.TextBox txtCourse4Grade;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblOutputCourse5;
        private System.Windows.Forms.TextBox txtCourse5Grade;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.Label lblOutputCourse6;
        private System.Windows.Forms.TextBox txtCourse6Grade;
        private System.Windows.Forms.Label lblCourse6;
        private System.Windows.Forms.Label lblOutputCourse7;
        private System.Windows.Forms.TextBox txtCourse7Grade;
        private System.Windows.Forms.Label lblCourse7;
        private System.Windows.Forms.Label lblOutputAverageGradeNumber;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblOutputAverageLetterGrade;
        private System.Windows.Forms.Label lblOutputErrors;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

