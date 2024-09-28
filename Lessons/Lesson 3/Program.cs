//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>26-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_3
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
            Person person;          // declares person as object of type Person
            person = new Person();  // creates instance of object  

            person.Name ="My name";
            person.Age = 30;

            // this is the same as the previous lines
            Person person_2 = new Person(30, "My name");

            person_2.DisplayValue(); // using method

            // this is the same as the previous 2 lines
            Person person_3 = new Person();
            person_3.Name = "My name";
            person_3.Age = 30;
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}"); // using get
            person_3.DisplayValue(); // using method

            // using GetAge() method
            int age = person_3.GetAge();
            Console.WriteLine($"Age: {age}");

            // using GetName() method
            string name = person_3.GetName();
            Console.WriteLine($"Name: {name}");

            #endregion
        }
    }
}