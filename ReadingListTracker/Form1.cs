/*
 * Author: Eisha Aqeel
 * Date: March 11, 2022
 * Description: I created a class where the object is books and this application will 
 * add copies of that object to a list collection and display it using a multi-column listview.
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

namespace ICE4_Class
{
    public partial class Form1 : Form
    {
        private List<Book> readingList = new List<Book>();
        private bool isAutomated = false;
        // Variable representing the current selected index in the ListView:
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
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

        /// <summary>
        /// Reset button function
        /// </summary>
        private void SetDefaults()
        {
            txtTitle.Clear();
            txtPages.Clear();
            txtAuthor.Clear();
            checkBoxRead.Checked = false;
            listViewBooks.SelectedItems.Clear();
            lblError.Text = String.Empty;
            selectedIndex = -1;
            // Set a default focus.
            txtTitle.Focus();
        }
        // Resets fields to default state. 
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private bool IsBookValid(string title, string pages, string author)
        {
            // Assume the book is valid.
            bool isValid = true;

            // Check the first input, it cannot be blank
            if (title == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "You must enter a book title.\n";
            }
            // Check the second input, it cannot be blank
            if (pages == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "You must enter the number of pages.\n";
            }
            // Check the third input, it cannot be blank
            if (author == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "You must enter the book author.\n";
            }

            return isValid;
        }

        private void PopulateListView(List<Book> booksList)
        {
            // Clear the listView to start re-populating it.
            listViewBooks.Items.Clear();

            foreach (Book newBook in booksList)
            {
                // Declare and instantiate a new ListViewItem.
                ListViewItem bookItem = new ListViewItem();

                // Allow the program to modify the ListView's checkboxes.
                isAutomated = true;
                bookItem.Checked = newBook.ReadStatus;
                bookItem.SubItems.Add(newBook.Title);
                bookItem.SubItems.Add(newBook.Page);
                bookItem.SubItems.Add(newBook.Author);

                // Add the bookItem to the ListView.
                listViewBooks.Items.Add(bookItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Empty the error label, it will fill with new errors if anything is wrong:
            lblError.Text = String.Empty;
            // Check if the book being entered is valid.
            if (IsBookValid(txtTitle.Text, txtPages.Text, txtAuthor.Text))
            {
                // Users details are valid; create a book object.
                Book newbookToAdd = new Book(txtTitle.Text, txtPages.Text, txtAuthor.Text, checkBoxRead.Checked);

                // If a book is currently selected...
                if (selectedIndex >= 0)
                {
                    // Replace the old version with the new one!
                    readingList[selectedIndex] = newbookToAdd;
                }
                else
                {
                    // Otherwise, add a book with the entered details to the end of the list.
                    readingList.Add(newbookToAdd);

                    //using static method:
                    Book.Count(+1);
                    
                }

                // Refresh the entire listView.
                PopulateListView(readingList);

                //valid input entered, do set defaults agian
                SetDefaults();
            }
        }
    }
}