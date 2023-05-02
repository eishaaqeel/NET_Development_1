
namespace Lab04_Contact_Tracer
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
            this.components = new System.ComponentModel.Container();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.columnHeaderContacted = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(197, 58);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(215, 23);
            this.txtLastName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtLastName, "Enter the person\'s last name");
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(197, 20);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 23);
            this.txtFirstName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtFirstName, "Enter the person\'s first name");
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(118, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 21);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "&Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(118, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 21);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "&First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Location = new System.Drawing.Point(102, 94);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(89, 21);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "&Email Address:";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 23);
            this.txtEmail.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtEmail, "Enter the person\'s Email Address");
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(96, 131);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(95, 21);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "&Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(197, 129);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(215, 23);
            this.txtPhoneNumber.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtPhoneNumber, "Enter the person\'s Phone Number");
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxContacted.Location = new System.Drawing.Point(128, 160);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(88, 29);
            this.checkBoxContacted.TabIndex = 9;
            this.checkBoxContacted.Text = "&Contacted?";
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Select if the person has been contacted");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // listViewContacts
            // 
            this.listViewContacts.CheckBoxes = true;
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderContacted,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderEmail,
            this.columnHeaderPhoneNumber,
            this.columnHeaderDate});
            this.listViewContacts.FullRowSelect = true;
            this.listViewContacts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewContacts.HideSelection = false;
            this.listViewContacts.Location = new System.Drawing.Point(12, 195);
            this.listViewContacts.MultiSelect = false;
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(464, 113);
            this.listViewContacts.TabIndex = 10;
            this.toolTip1.SetToolTip(this.listViewContacts, "Display a list of all contacts");
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderContacted
            // 
            this.columnHeaderContacted.Text = "Contacted";
            this.columnHeaderContacted.Width = 70;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 70;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 70;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 90;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Phone Number";
            this.columnHeaderPhoneNumber.Width = 100;
            // 
            // lblError
            // 
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblError.Location = new System.Drawing.Point(12, 324);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(464, 64);
            this.lblError.TabIndex = 11;
            this.toolTip1.SetToolTip(this.lblError, "Displays all error messages");
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(78, 407);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(84, 22);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "E&nter";
            this.toolTip1.SetToolTip(this.btnEnter, "Click to enter the contact to the list");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(192, 407);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 22);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Click to reset all entry fields");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 407);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 22);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.listViewContacts);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(507, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(507, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.ColumnHeader columnHeaderContacted;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

