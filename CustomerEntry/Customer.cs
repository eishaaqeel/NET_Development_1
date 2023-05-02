// Customer.cs
// Author:  Eisha Aqeel
// Date:    March 11, 2022
// Description:
//  A class designed to as a record of an individual customer,
//  including a little information that describes their importance.

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomerViewer
{
    /// <summary>
    /// A class designed to as a record of an individual customer, including a little information that describes their importance.
    /// </summary>
    class Customer
    {
        // Static private variable to hold the number of customers.
        private static int customerCount = 0;
        // Private variable to hold the customer's identification number.
        private int customerId = 0;
        // Private variable to hold the customer's title.
        private string customerTitle = String.Empty;
        // Private variable to hold the customer's first name.
        private string customerFirstName = String.Empty;
        // Private variable to hold the customer's last name.
        private string customerLastName = String.Empty;
        // Private variable to hold the customer's status.
        private bool customerVipStatus = false;

        /// <summary>
        /// Constructor - Default - creates a new customer object.
        /// </summary>
        public Customer()
        {
            customerCount += 1;
            customerId = customerCount;
        }

        /// <summary>
        /// Constructor - Parameterized - creates a new customer object
        /// </summary>
        /// <param name="title">Customer's title</param>
        /// <param name="firstName">Customer's first name</param>
        /// <param name="lastName">Customer's last name</param>
        /// <param name="vipStatus">true if a customer is a very important person</param>
        public Customer(string title, string firstName, string lastName, bool vipStatus): this()
        {
            // The ": this()" part above calls the default constructor, setting the Id.

            // Set all of the instance variables within this class using the values
            // passed into this constructor.
            customerTitle = title;
            customerFirstName = firstName;
            customerLastName = lastName;
            customerVipStatus = vipStatus;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of customers that have been instantiated/created
        /// </summary>
        public int Count
        {
            get
            {
                return customerCount;
            }
        }

        /// <summary>
        /// IdentificationNumber ReadOnly Property - Gets a specific customers' identification number
        /// </summary>
        public int Id
        {
            get
            {
                return customerId;
            }
        }

        /// <summary>
        /// VeryImportantPersonStatus Property - >Gets and Sets the Very Important Person status of a customer
        /// </summary>
        public bool VipStatus
        {
            get
            {
                return customerVipStatus;
            }
            set
            {
                // The value passed in is always called "value" by default.
                customerVipStatus = value;
            }
        }

        /// <summary>
        /// Title property - Gets and Sets the title of a customer
        /// </summary>
        public string Title
        {
            get
            {
                return customerTitle;
            }
            set
            {
                // The value passed in is always called "value" by default - regardless of the data type.
                customerTitle = value;
            }
        }

        /// <summary>
        /// FirstName property - Gets and Sets the first name of a customer
        /// </summary>
        public string FirstName
        {
            get
            {
                return customerFirstName;
            }
            set
            {
                customerFirstName = value;
            }
        }

        /// <summary>
        /// LastName property - Gets and Sets the last name of a customer
        /// </summary>
        public string LastName
        {
            get
            {
                return customerLastName;
            }
            set
            {
                customerLastName = value;
            }
        }

        /// <summary>
        /// GetSalutation is a function that a salutation based on the private properties within the class scope
        /// </summary>
        /// <returns>string describing the customer</returns>
        public string GetSalutation()
        {
            return "Hi, my name is " + customerTitle + " " + customerFirstName + " " + customerLastName + ", " + (customerVipStatus ? "I am a VIP" : "I am not a VIP");

            // The single line of code above is equivalent to the following eight lines of code:
            //if (customerVipStatus)
            //{
            //    return "Hi, my name is " + customerTitle + " " + customerFirstName + " " + customerLastName + ", I am a VIP";
            //}
            //else
            //{
            //    return "Hi, my name is " + customerTitle + " " + customerFirstName + " " + customerLastName + ", I am not a VIP";
            //}
        }

        #region File I/O
        public static void FileWrite(List<Customer> customers, string filename)
        {
            FileStream fWrite = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sWrite = new StreamWriter(fWrite);
            sWrite.Write(FileCreateCSV(customers));
            sWrite.Close();
        }
        private static String FileCreateCSV(List<Customer> troopers)
        {
            String returnString = string.Empty;
            String line = string.Empty;
            foreach (Customer t in troopers)
            {
                line = t.Title + ","
                     + t.FirstName + ","
                     + t.LastName + ","
                     + t.VipStatus + ",";
                returnString += line;
            }
            return returnString;
        }

        public static List<Customer> LoadFromCSV(String filename)
        {
            List<Customer> rl = new List<Customer>();
            FileStream fileRead = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sRead = new StreamReader(fileRead);

            String lineContent = string.Empty;
            String[] items = new string[8];
            Customer t;

            while (!sRead.EndOfStream)
            {
                try
                {
                    lineContent = sRead.ReadLine();
                    items = new string[8];
                    items = lineContent.Split(",");
                    t = new Customer();
                    t.Title = items[0];
                    t.FirstName = items[1];
                    t.LastName = items[2];
                    t.VipStatus = Convert.ToBoolean(items[3]);

                    rl.Add(t);
                }
                catch
                {

                }
            }
            sRead.Close();
            fileRead.Close();
            return rl;
        }
        #endregion
    }
}
