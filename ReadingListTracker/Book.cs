/*
 * Author: Eisha Aqeel
 * Date: March 11, 2022
 * Description: This is a class that repersents the object books.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE4_Class
{
    class Book
    {
        // Static private variable to hold the number of books.
        private static int bookCount = 0;
        // Private variable to hold the books title.
        private string bookTitle = String.Empty;
        // Private variable to hold the books pages.
        private string bookPages = String.Empty;
        // Private variable to hold the books author.
        private string bookAuthor = String.Empty;
        // Private variable to hold the reading status.
        private bool readingStatus = false;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Book()
        {
            bookCount += 1;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="pages"></param>
        /// <param name="author"></param>
        /// <param name="read"></param>
        public Book(string title, string pages, string author, bool read) : this()
        {
            // The ": this()" part above calls the default constructor, setting the Id.
            //The private variables within the class will be set using the values passed into these parameters
            bookTitle = title;
            bookPages = pages;
            bookAuthor = author;
            readingStatus = read;
        }

        /// <summary>
        /// Static Method
        /// </summary>
        public static void Count(int bookCount)
        {
            bookCount++;
        }

        /// <summary>
        /// Title property - Gets and Sets the title of a book
        /// </summary>
        public string Title
        {
            get
            {
                return bookTitle;
            }
            set
            {
                bookTitle = value;
            }
        }

        /// <summary>
        /// Page property - Gets and Sets the numner of pages on the book
        /// </summary>
        public string Page
        {
            get
            {
                return bookPages;
            }
            set
            {
                bookPages = value;
            }
        }

        /// <summary>
        /// Author  property - Gets and Sets the Author of a book
        /// </summary>
        public string Author
        {
            get
            {
                return bookAuthor;
            }
            set
            {
                bookAuthor = value;
            }
        }

        public bool ReadStatus
        {
            get
            {
                return readingStatus;
            }
            set
            {
                // The value passed in is always called "value" by default.
                readingStatus = value;
            }
        }

    }
}
