
namespace Lab03_Regions_Weekly_Cases
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
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            txtAddCases = new System.Windows.Forms.TextBox();
            lblOutputRegion1Average = new System.Windows.Forms.Label();
            lblOutputRegion2Average = new System.Windows.Forms.Label();
            lblOutputRegion3Average = new System.Windows.Forms.Label();
            lblOutputOverallAverage = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            btnEnter = new System.Windows.Forms.Button();
            txtRegion1 = new System.Windows.Forms.TextBox();
            txtRegion2 = new System.Windows.Forms.TextBox();
            txtRegion3 = new System.Windows.Forms.TextBox();
            lblRegion1 = new System.Windows.Forms.Label();
            lblRegion2 = new System.Windows.Forms.Label();
            lblRegion3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblCases
            // 
            lblCases.AutoSize = true;
            lblCases.Location = new System.Drawing.Point(12, 15);
            lblCases.Name = "lblCases";
            lblCases.Size = new System.Drawing.Size(40, 15);
            lblCases.TabIndex = 1;
            lblCases.Text = "&Cases:";
            // 
            // txtAddCases
            // 
            txtAddCases.Location = new System.Drawing.Point(58, 12);
            txtAddCases.Name = "txtAddCases";
            txtAddCases.Size = new System.Drawing.Size(100, 23);
            txtAddCases.TabIndex = 2;
            toolTip1.SetToolTip(txtAddCases, "Enter the number of cases");
            // 
            // lblOutputRegion1Average
            // 
            lblOutputRegion1Average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblOutputRegion1Average.Location = new System.Drawing.Point(12, 261);
            lblOutputRegion1Average.Name = "lblOutputRegion1Average";
            lblOutputRegion1Average.Size = new System.Drawing.Size(131, 30);
            lblOutputRegion1Average.TabIndex = 9;
            lblOutputRegion1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputRegion1Average, "This is where it shows the average weekly cases, for Region 1");
            // 
            // lblOutputRegion2Average
            // 
            lblOutputRegion2Average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblOutputRegion2Average.Location = new System.Drawing.Point(159, 261);
            lblOutputRegion2Average.Name = "lblOutputRegion2Average";
            lblOutputRegion2Average.Size = new System.Drawing.Size(131, 30);
            lblOutputRegion2Average.TabIndex = 10;
            lblOutputRegion2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputRegion2Average, "This is where it shows the average weekly cases, for Region 2");
            // 
            // lblOutputRegion3Average
            // 
            lblOutputRegion3Average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblOutputRegion3Average.Location = new System.Drawing.Point(307, 261);
            lblOutputRegion3Average.Name = "lblOutputRegion3Average";
            lblOutputRegion3Average.Size = new System.Drawing.Size(131, 30);
            lblOutputRegion3Average.TabIndex = 11;
            lblOutputRegion3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputRegion3Average, "This is where it shows the average weekly cases, for Region 3");
            // 
            // lblOutputOverallAverage
            // 
            lblOutputOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblOutputOverallAverage.Location = new System.Drawing.Point(12, 302);
            lblOutputOverallAverage.Name = "lblOutputOverallAverage";
            lblOutputOverallAverage.Size = new System.Drawing.Size(426, 32);
            lblOutputOverallAverage.TabIndex = 12;
            lblOutputOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblOutputOverallAverage, "This is where it shows the overall  average weekly cases");
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(307, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(131, 23);
            btnExit.TabIndex = 15;
            btnExit.Text = "E&xit";
            toolTip1.SetToolTip(btnExit, "Exit the application");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(159, 350);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(131, 23);
            btnReset.TabIndex = 14;
            btnReset.Text = "&Reset";
            toolTip1.SetToolTip(btnReset, "Reset the entire form to its default values");
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new System.Drawing.Point(12, 350);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(131, 23);
            btnEnter.TabIndex = 13;
            btnEnter.Text = "&Enter";
            toolTip1.SetToolTip(btnEnter, "Press to add the number of cases to the list");
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtRegion1
            // 
            txtRegion1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            txtRegion1.Location = new System.Drawing.Point(27, 79);
            txtRegion1.Multiline = true;
            txtRegion1.Name = "txtRegion1";
            txtRegion1.ReadOnly = true;
            txtRegion1.Size = new System.Drawing.Size(101, 169);
            txtRegion1.TabIndex = 6;
            toolTip1.SetToolTip(txtRegion1, "Daily cases in Region 1");
            // 
            // txtRegion2
            // 
            txtRegion2.BackColor = System.Drawing.SystemColors.HighlightText;
            txtRegion2.Location = new System.Drawing.Point(175, 79);
            txtRegion2.Multiline = true;
            txtRegion2.Name = "txtRegion2";
            txtRegion2.ReadOnly = true;
            txtRegion2.Size = new System.Drawing.Size(101, 169);
            txtRegion2.TabIndex = 7;
            toolTip1.SetToolTip(txtRegion2, "Daily cases in Region2");
            // 
            // txtRegion3
            // 
            txtRegion3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtRegion3.Location = new System.Drawing.Point(323, 79);
            txtRegion3.Multiline = true;
            txtRegion3.Name = "txtRegion3";
            txtRegion3.ReadOnly = true;
            txtRegion3.Size = new System.Drawing.Size(100, 169);
            txtRegion3.TabIndex = 8;
            toolTip1.SetToolTip(txtRegion3, "Daily cases in Region3");
            // 
            // lblRegion1
            // 
            lblRegion1.AutoSize = true;
            lblRegion1.Location = new System.Drawing.Point(48, 51);
            lblRegion1.Name = "lblRegion1";
            lblRegion1.Size = new System.Drawing.Size(53, 15);
            lblRegion1.TabIndex = 3;
            lblRegion1.Text = "Region &1";
            // 
            // lblRegion2
            // 
            lblRegion2.AutoSize = true;
            lblRegion2.Location = new System.Drawing.Point(202, 51);
            lblRegion2.Name = "lblRegion2";
            lblRegion2.Size = new System.Drawing.Size(53, 15);
            lblRegion2.TabIndex = 4;
            lblRegion2.Text = "Region &2";
            // 
            // lblRegion3
            // 
            lblRegion3.AutoSize = true;
            lblRegion3.Location = new System.Drawing.Point(345, 51);
            lblRegion3.Name = "lblRegion3";
            lblRegion3.Size = new System.Drawing.Size(53, 15);
            lblRegion3.TabIndex = 5;
            lblRegion3.Text = "Region &3";
            // 
            // Form1
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            CancelButton = btnReset;
            ClientSize = new System.Drawing.Size(450, 385);
            Controls.Add(txtRegion3);
            Controls.Add(txtRegion2);
            Controls.Add(txtRegion1);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnEnter);
            Controls.Add(lblOutputOverallAverage);
            Controls.Add(lblOutputRegion3Average);
            Controls.Add(lblOutputRegion2Average);
            Controls.Add(lblOutputRegion1Average);
            Controls.Add(lblRegion3);
            Controls.Add(lblRegion2);
            Controls.Add(lblRegion1);
            Controls.Add(txtAddCases);
            Controls.Add(lblCases);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(466, 424);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(466, 424);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Average Weekly Cases by Region";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtAddCases;
        private System.Windows.Forms.Label lblRegion1;
        private System.Windows.Forms.Label lblRegion2;
        private System.Windows.Forms.Label lblRegion3;
        private System.Windows.Forms.Label lblOutputRegion1Average;
        private System.Windows.Forms.Label lblOutputRegion2Average;
        private System.Windows.Forms.Label lblOutputRegion3Average;
        private System.Windows.Forms.Label lblOutputOverallAverage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtRegion1;
        private System.Windows.Forms.TextBox txtRegion2;
        private System.Windows.Forms.TextBox txtRegion3;
    }
}

