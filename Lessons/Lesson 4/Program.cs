//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>03-10-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_4
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
            #region Person

            // Create a new person object
            Person person = new Person("Alice", 30);
            person.DisplayValue();

            #endregion

            #region Student

            // Create a new student object
            Student student = new Student("Bob", 20, "S12345", "Computer Science");
            student.DisplayValue();

            #endregion
        }
    }
}