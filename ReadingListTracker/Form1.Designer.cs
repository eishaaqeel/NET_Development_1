
namespace ICE4_Class
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.columnHeaderRead = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPages = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor = new System.Windows.Forms.ColumnHeader();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(12, 379);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(78, 22);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Press to enter the book to the list");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 379);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 22);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "R&eset";
            this.toolTip1.SetToolTip(this.btnReset, "Click to reset all entry fields");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 379);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 22);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblError
            // 
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblError.Location = new System.Drawing.Point(12, 291);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(289, 64);
            this.lblError.TabIndex = 9;
            this.toolTip1.SetToolTip(this.lblError, "Error messages should be shown here");
            // 
            // listViewBooks
            // 
            this.listViewBooks.CheckBoxes = true;
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRead,
            this.columnHeaderTitle,
            this.columnHeaderPages,
            this.columnHeaderAuthor});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(12, 159);
            this.listViewBooks.MultiSelect = false;
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(289, 113);
            this.listViewBooks.TabIndex = 8;
            this.toolTip1.SetToolTip(this.listViewBooks, "This is your list of books");
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRead
            // 
            this.columnHeaderRead.Text = "Read?";
            this.columnHeaderRead.Width = 45;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Book Title";
            this.columnHeaderTitle.Width = 100;
            // 
            // columnHeaderPages
            // 
            this.columnHeaderPages.Text = "Pages";
            this.columnHeaderPages.Width = 50;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 90;
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRead.Location = new System.Drawing.Point(68, 114);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(70, 29);
            this.checkBoxRead.TabIndex = 7;
            this.checkBoxRead.Text = "&Read?";
            this.toolTip1.SetToolTip(this.checkBoxRead, "Have you read this book or not yet?");
            this.checkBoxRead.UseVisualStyleBackColor = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(111, 86);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(162, 23);
            this.txtAuthor.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtAuthor, "Enter the author of the book");
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(48, 86);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(56, 21);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "&Author:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(111, 50);
            this.txtPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(162, 23);
            this.txtPages.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPages, "Enter the number of pages of the book");
            // 
            // lblPages
            // 
            this.lblPages.Location = new System.Drawing.Point(55, 50);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(49, 21);
            this.lblPages.TabIndex = 3;
            this.lblPages.Text = "&Pages:";
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 11);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(162, 23);
            this.txtTitle.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTitle, "Enter a book title");
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(68, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "&Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(322, 418);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.checkBoxRead);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(338, 457);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 457);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books To Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ColumnHeader columnHeaderRead;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderPages;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

