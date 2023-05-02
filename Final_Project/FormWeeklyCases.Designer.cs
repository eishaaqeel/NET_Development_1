
namespace Final_Project
{
    partial class FormWeeklyCases
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
            this.components = new System.ComponentModel.Container();
            this.lblCases = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbxEntry = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(87, 98);
            this.lblCases.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(79, 32);
            this.lblCases.TabIndex = 0;
            this.lblCases.Text = "&Cases:";
            this.toolTip1.SetToolTip(this.lblCases, "case input lable");
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(188, 92);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(273, 39);
            this.txtInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtInput, "Input the case by the day");
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(615, 98);
            this.lblDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(24, 32);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "-";
            this.toolTip1.SetToolTip(this.lblDays, "day of week");
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(87, 627);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(596, 57);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output Label";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblOutput, "Average Case per day");
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(87, 730);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(139, 49);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "enter to entries");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(325, 730);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 49);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "reset the app");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(546, 730);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "close the app");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbxEntry
            // 
            this.lbxEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxEntry.FormattingEnabled = true;
            this.lbxEntry.ItemHeight = 32;
            this.lbxEntry.Location = new System.Drawing.Point(87, 177);
            this.lbxEntry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbxEntry.Name = "lbxEntry";
            this.lbxEntry.Size = new System.Drawing.Size(595, 420);
            this.lbxEntry.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lbxEntry, "Entreis of the cases");
            // 
            // FormWeeklyCases
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(750, 830);
            this.Controls.Add(this.lbxEntry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCases);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(776, 901);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(776, 901);
            this.Name = "FormWeeklyCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormWeeklyCases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lbxEntry;
    }
}

