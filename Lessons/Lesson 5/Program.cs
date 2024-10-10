//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>09-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_5
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

            // Create a new person object and display values (NOT ALLOWED, Person is Abstract Class)
            // Person person = new Person("Alice", 30);
            // person.DisplayValue();

            #endregion

            #region Student

            List<Student> students = new List<Student>
            {
                new Student("Ivan", new DateOnly(2000, 10, 08), "asjah", "A"),
                new Student("Malk", new DateOnly(1980, 10, 07), "asjah", "B"),
                new Student("Uih", new DateOnly(1970, 11, 24), "asjah", "C"),
            };
            
            foreach (Student st in students)
            {
                Console.WriteLine(st.ReturnsValues());
                Console.WriteLine();
            }
            
            Student student = new Student();
            
            Console.WriteLine(student.CalculateAge(new DateOnly(1980, 11, 24)));

            #endregion
        }
    }
}