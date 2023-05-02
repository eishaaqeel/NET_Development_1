#region Info
/* Authors : Hongju Shin & Eisha Aqeel
 * Date: 17 Apr 2022
 * Description: Contact class to be used with the ContactTracer application
 */
#endregion



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Contact
    {
        // Static private variable to hold the number of contacts.
        private static int contactCount = 0;
        // Private variable to hold the contact's identification number.
        private int contactsId = 0;
        // Private variable to hold the contacts first name.
        private string contactsFirstName = String.Empty;
        // Private variable to hold the contacts last name.
        private string contactsLastName = String.Empty;
        // Private variable to hold the contacts EmailAddress .
        private string contactsEmailAddress = String.Empty;
        // Private variable to hold the contacts PhoneNumber .
        private string contactsPhoneNumber = String.Empty;
        //Private variable to hold the contacts DateTime.Now
        private DateTime contactsDate = DateTime.Now;
        // Private variable to hold the contacts status.
        private bool contactedStatus = false;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Contact()
        {
            //increment the customer count
            contactCount += 1;
            //set this customer’s Id based on this updated customer count
            contactsId = contactCount;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="contactStatus"></param>
        public Contact(string firstName, string lastName, string emailAddress, string phoneNumber, bool contactStatus) : this()
        {
            // The ": this()" part above calls the default constructor, setting the Id.
            //The private variables within the class will be set using the values passed into these parameters
            contactsFirstName = firstName;
            contactsLastName = lastName;
            contactsEmailAddress = emailAddress;
            contactsPhoneNumber = phoneNumber;
            contactedStatus = contactStatus;
        }

        /// <summary>
        /// Count (Integer) – a static ReadOnly property referring to the total number of customer objects
        /// </summary>
        static int Count
        {
            get
            {
                return contactCount;
            }
        }

        /// <summary>
        /// Id (Integer) – a ReadOnly property with a unique identifier for entered customer
        /// </summary>
        public int Id
        {
            get
            {
                return contactsId;
            }
        }

        /// <summary>
        /// FirstName property - Gets and Sets the first name of a contact
        /// </summary>
        public string FirstName
        {
            get
            {
                return contactsFirstName;
            }
            set
            {
                contactsFirstName = value;
            }
        }

        /// <summary>
        /// LastName property - Gets and Sets the last name of a contact
        /// </summary>
        public string LastName
        {
            get
            {
                return contactsLastName;
            }
            set
            {
                contactsLastName = value;
            }
        }

        /// <summary>
        /// EmailAddress  property - Gets and Sets the Email Address of a contact
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return contactsEmailAddress;
            }
            set
            {
                contactsEmailAddress = value;
            }
        }

        /// <summary>
        /// PhoneNumber property - Gets and Sets the last Phone Number of a contact
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return contactsPhoneNumber;
            }
            set
            {
                contactsPhoneNumber = value;
            }
        }

        /// <summary>
        /// ReadOnly property that populates using DateTime.Now
        /// </summary>
        public DateTime Date
        {
            get
            {
                return contactsDate;
            }
            set
            {
                // The value passed in is always called "value" by default.
                contactsDate = DateTime.Now;
            }
        }

        /// <summary>
        /// ContactStatus (Boolean) Property - >Gets and Sets the status of a contact
        /// </summary>
        public bool ContactStatus
        {
            get
            {
                return contactedStatus;
            }
            set
            {
                // The value passed in is always called "value" by default.
                contactedStatus = value;
            }
        }

        /// <summary>
        /// GetStatus() function
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            return FirstName + " " + LastName + " (" + EmailAddress + "/" + PhoneNumber + ") from " 
                + Date + (ContactStatus ? "has been contacted." : "has not been contacted.");
        }

    }
    }
