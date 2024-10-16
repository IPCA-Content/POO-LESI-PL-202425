//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>16-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_6.Enums;
using Lesson_6.Models;

namespace Lesson_6
{
    /// <summary>
    /// Summary description for Lesson.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            #region Call my Code (New)
            // Create authors
            Author author1 = new Author("John Doe");
            Author author2 = new Author("Jane Smith");

            // Create publisher (using context manager to dispose object in the end)
            using (Publisher publisher = new Publisher("TechBooks", 2023))
            {
                // Create a book
                Book book1 = new Book(
                    "Learning OOP with C#", 
                    "English", 
                    FormatType.Physical,
                    [author1, author2], 
                    publisher,
                    CategoryType.Entertainment);
            
                Book book2 = new Book(
                    "Learning OOP Java", 
                    "Portuguese", 
                    FormatType.Digital,
                    [author1, author2], 
                    publisher,
                    CategoryType.Scientific);
            
                // Create users
                Staff staff = new Staff("John Doe");
                Student student = new Student("Alice Johnson");
                Professor professor = new Professor("Dr. Bob Green");

                // Create a library with constructor
                Library library = new Library();

                // Register users
                library.RegisterUser(staff);
                library.RegisterUser(student);
                library.RegisterUser(student); // Will show "User Alice Johnson is already registered."
            
                library.RegisterUser(professor);

                // Add items to the library
                library.AddItem(book1);
                library.AddItem(book2);

                // Borrow items
                library.BorrowItem(staff, book1);
                library.BorrowItem(student, book1); // requested 2 times the same
                library.BorrowItem(professor, book2);
                
                // List items in the library, after being taken
                library.ListItems();

                // Return borrow items
                library.ReturnItem(student, book1);
                library.ReturnItem(professor, book2);

                // List items in the library
                library.ListItems();
            }
            
            #endregion
        }
    }
}