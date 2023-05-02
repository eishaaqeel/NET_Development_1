
namespace Final_Project
{
    partial class Awesomeness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Awesomeness));
            lblQuestion = new System.Windows.Forms.Label();
            btnYes = new System.Windows.Forms.Button();
            btnNo = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblQuestion.Location = new System.Drawing.Point(15, 32);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(303, 114);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "This computer has detected that Hongju and Eisha are awesome. Do you agree?";
            lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lblQuestion, "In Jan of 2022, the computer has detected that Hongju and Eisha is awesome.  Is it possible that they are awesome?");
            lblQuestion.Click += label1_Click_1;
            // 
            // btnYes
            // 
            btnYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnYes.Location = new System.Drawing.Point(15, 200);
            btnYes.Name = "btnYes";
            btnYes.Size = new System.Drawing.Size(75, 40);
            btnYes.TabIndex = 1;
            btnYes.Text = "&Yes";
            toolTip1.SetToolTip(btnYes, "Yes button");
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNo.Location = new System.Drawing.Point(100, 200);
            btnNo.Name = "btnNo";
            btnNo.Size = new System.Drawing.Size(75, 40);
            btnNo.TabIndex = 2;
            btnNo.Text = "&No";
            toolTip1.SetToolTip(btnNo, "No button");
            btnNo.UseVisualStyleBackColor = true;
            btnNo.MouseHover += mouse_hover;
            // 
            // Awesomeness
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnNo;
            ClientSize = new System.Drawing.Size(344, 261);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Awesomeness";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Awesomeness - <Group 1>";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

