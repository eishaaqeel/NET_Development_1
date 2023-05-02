#region Info
/* Authors : Hongju Shin & Eisha Aqeel
 * Date: 17 Apr 2022
 * Description: ContactTracer Form
 */
#endregion


#region Usings
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

namespace Final_Project
{
    public partial class ContactTracer : Form
    {
        private List<Contact> contactList = new List<Contact>();
        // This flag is used to indicate whether the program is checking boxes as opposed to a human.

        private bool isAutomated = false;

        // Variable representing the current selected index in the ListView:
        private int selectedIndex = -1;

        #region Form Constructor
        public ContactTracer()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Enter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Empty the error label, it will fill with new errors if anything is wrong:
            lblError.Text = String.Empty;
     
            // Check if the contact being entered is valid.
            if (IsCustomerValid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text))
            {
                // Users details are valid; create a contact object.
                Contact newContactToAdd = new Contact(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text, checkBoxContacted.Checked);

                // If a person is currently selected...
                if (selectedIndex >= 0)
                {
                    // Replace the old version of that contact with the new one!
                    contactList[selectedIndex] = newContactToAdd;
                }
                else
                {
                    // Otherwise, add a contact with the entered details to the end of the list.
                    contactList.Add(newContactToAdd);
                }

                // Refresh the entire listView.
                PopulateListView(contactList);

                //valid input entered, do set defaults agian
                SetDefaults();
            }
            
        }

        /// <summary>
        /// Converts the contact passed in to a ListViewItem and adds it to listViewContacts
        /// </summary>
        /// <param name="contactsList"></param>
        private void PopulateListView(List<Contact> contactsList)
        {
            // Clear the listView to start re-populating it.
            listViewContacts.Items.Clear();

            foreach (Contact newContact in contactsList)
            {
                // Declare and instantiate a new ListViewItem.
                ListViewItem contactItem = new ListViewItem();

                // Allow the program to modify the ListView's checkboxes.
                isAutomated = true;
                contactItem.Checked = newContact.ContactStatus;
                contactItem.SubItems.Add(newContact.FirstName);
                contactItem.SubItems.Add(newContact.LastName);
                //contactItem.SubItems.Add(newContact.Date);
                contactItem.SubItems.Add(newContact.EmailAddress);
                contactItem.SubItems.Add(newContact.PhoneNumber);

                // Add the customerItem to the ListView.
                listViewContacts.Items.Add(contactItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;
            }
        }

        /// <summary>
        /// Reset button function
        /// </summary>
        private void SetDefaults()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            checkBoxContacted.Checked = false;
            listViewContacts.SelectedItems.Clear();
            lblError.Text = String.Empty;
            selectedIndex = -1;
            // Set a default focus.
            txtFirstName.Focus();
        }
        // Resets fields to default state. 
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        /// <summary>
        /// When a contact in the ListView is selected, write that person's properties into the input controls.
        /// </summary>
        private void ContactSelected(object sender, EventArgs e)
        {
            // If the list is populated and something is selected...
            if (listViewContacts.Items.Count > 0 && listViewContacts.FocusedItem != null)
            {
                // ...fill in the entry fields with values based on the selected customer.
                txtFirstName.Text = listViewContacts.FocusedItem.SubItems[1].Text;
                txtLastName.Text = listViewContacts.FocusedItem.SubItems[2].Text;
                txtEmail.Text = listViewContacts.FocusedItem.SubItems[3].Text;
                txtPhoneNumber .Text = listViewContacts.FocusedItem.SubItems[4].Text;
                checkBoxContacted.Checked = listViewContacts.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewContacts.FocusedItem.Index;
            }
            else
            {
                // If nothing is selected, set the selectedIndex to -1.
                selectedIndex = -1;
            }
        }

        /// <summary>
        /// When a checkbox in the ListView is checked, say no and don't let the user change it.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        /// <summary>
        /// Validation function
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private bool IsCustomerValid(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            // Assume the worker is valid.
            bool isValid = true;

            // Check the first input, it cannot be blank
            if (firstName == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "You must enter a first name.\n";
            }
            // Check the second input, it cannot be blank
            if (lastName == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "You must enter a last name.\n";
            }

            // Check the third input, it should have “@” in the input
            //got some of this code from online
            string trimmedEmail = emailAddress.Trim();
            try
            {
                var addr = new System.Net.Mail.MailAddress(emailAddress);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "Your email address must be entered in a valid format.\n";
            }
            

            // Check the forth input.
            if (phoneNumber.Length < 10)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                lblError.Text += "Your phone number must be entered in a valid format.";
            }

            return isValid;
        }

    }
}
