//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>07-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson10.Models;
using Lesson10.Models.PersonVsPersons;

namespace Lesson10
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
            #region Exercise - Diploma
            StaffDiploma staffDiploma = new StaffDiploma("Alice", DateTime.Now.AddYears(-2));
            Console.WriteLine(staffDiploma.DisplayInfo());

            TeacherDiploma teacherDiploma = new TeacherDiploma("Bob", DateTime.Now.AddYears(-5), "Mathematics", "Professor Titular");
            Console.WriteLine(teacherDiploma.DisplayInfo());

            StudentDiploma studentDiploma = new StudentDiploma(12345, "Charlie", "Computer Science");
            Console.WriteLine(studentDiploma.DisplayInfo());
            #endregion
            
            #region Exercise - Bank
            SavingsAccount savingsAccount = new SavingsAccount(1000.0f);
            Console.WriteLine($"Savings Account Commission: {savingsAccount.CalculateCommission()}");

            InvestmentAccount investmentAccount = new InvestmentAccount(1000.0f);
            Console.WriteLine($"Investment Account Commission: {investmentAccount.CalculateCommission()}");
            #endregion
            
            #region Exercise - Person vs Persons
            // Create the Persons manager and add people
            Persons persons = new Persons();
            persons.AddPerson(new Person("Alice", 30));
            persons.AddPerson(new Person("Bob", 25));
            persons.AddPerson(new Person("Charlie", 40));

            // Introduce everyone
            persons.IntroduceEveryone();

            // Use PersonUtilities to find the oldest person
            List<Person> allPeople = persons.GetAllPeople();
            Person oldest = PersonUtilities.FindOldestPerson(allPeople);
            Console.WriteLine($"\nThe oldest person is {oldest.Name}, who is {oldest.Age} years old.");

            // Use PersonUtilities to calculate the average age
            double averageAge = PersonUtilities.CalculateAverageAge(allPeople);
            Console.WriteLine($"The average age is {averageAge:F2} years.");
            #endregion  
        }
    }
}