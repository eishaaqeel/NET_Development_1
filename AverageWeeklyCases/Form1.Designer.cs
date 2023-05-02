
namespace Lab01_Average_Weekly_Cases
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
            lblCases = new System.Windows.Forms.Label();
            txtAddCases = new System.Windows.Forms.TextBox();
            btnEnter = new System.Windows.Forms.Button();
            lbxCasesEntered = new System.Windows.Forms.ListBox();
            lblOutput = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblDays = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // lblCases
            // 
            lblCases.AutoSize = true;
            lblCases.Location = new System.Drawing.Point(12, 16);
            lblCases.Name = "lblCases";
            lblCases.Size = new System.Drawing.Size(40, 15);
            lblCases.TabIndex = 0;
            lblCases.Text = "&Cases:";
            // 
            // txtAddCases
            // 
            txtAddCases.Location = new System.Drawing.Point(60, 13);
            txtAddCases.Name = "txtAddCases";
            txtAddCases.Size = new System.Drawing.Size(100, 23);
            txtAddCases.TabIndex = 1;
            toolTip1.SetToolTip(txtAddCases, "Enter the number of cases for the day.");
            txtAddCases.KeyPress += txtAddCases_KeyPress;
            // 
            // btnEnter
            // 
            btnEnter.Location = new System.Drawing.Point(14, 255);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(75, 23);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "&Enter";
            toolTip1.SetToolTip(btnEnter, "Add the number of cases to the list");
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lbxCasesEntered
            // 
            lbxCasesEntered.FormattingEnabled = true;
            lbxCasesEntered.ItemHeight = 15;
            lbxCasesEntered.Location = new System.Drawing.Point(14, 55);
            lbxCasesEntered.Name = "lbxCasesEntered";
            lbxCasesEntered.SelectionMode = System.Windows.Forms.SelectionMode.None;
            lbxCasesEntered.Size = new System.Drawing.Size(268, 139);
            lbxCasesEntered.TabIndex = 3;
            toolTip1.SetToolTip(lbxCasesEntered, "This is where the 7 days of cases are displayed.");
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblOutput.Location = new System.Drawing.Point(14, 210);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new System.Drawing.Size(268, 23);
            lblOutput.TabIndex = 4;
            lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutput, "This is where it shows the average weekly cases.");
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(107, 255);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "&Reset";
            toolTip1.SetToolTip(btnReset, "Reset the entire form to its default values");
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(207, 255);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            toolTip1.SetToolTip(btnExit, "Exit the application");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new System.Drawing.Point(246, 16);
            lblDays.Name = "lblDays";
            lblDays.Size = new System.Drawing.Size(36, 15);
            lblDays.TabIndex = 7;
            lblDays.Text = "&Day 0";
            toolTip1.SetToolTip(lblDays, "This shows what day it is out of the week.");
            // 
            // Form1
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnReset;
            ClientSize = new System.Drawing.Size(294, 296);
            Controls.Add(lblDays);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(lblOutput);
            Controls.Add(lbxCasesEntered);
            Controls.Add(btnEnter);
            Controls.Add(txtAddCases);
            Controls.Add(lblCases);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(310, 335);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Average Weekly Cases";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.TextBox txtAddCases;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lbxCasesEntered;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDays;
    }
}

