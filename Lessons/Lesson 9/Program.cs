//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_9.Interfaces;
using Lesson_9.Models;

namespace Lesson_9
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
            // Create spacecrafts for different destinations
            Spacecraft lunarShuttle = new LunarShuttle { Name = "Apollo 11", Capacity = 4, BaseRentalRate = 500m };
            Spacecraft marsExplorer = new MarsExplorer { Name = "Mars Rover", Capacity = 6, BaseRentalRate = 1500m };

            // Rent a lunar shuttle for a 3-day journey to the moon, 238,900 miles away
            IRental lunarRental = new Rental(lunarShuttle, 3, 238900);
            lunarRental.CalculateRentalCost();
            lunarRental.PrintRentalSummary();

            // Process payment for the lunar rental
            IPayment lunarPayment = new Payment { PaymentMethod = "Galactic Credits" };
            lunarPayment.ProcessPayment(((Rental)lunarRental).TotalCost);

            Console.WriteLine();

            // Rent a Mars explorer for a 10-day journey to Mars, 225 million miles away
            IRental marsRental = new Rental(marsExplorer, 10, 225000000);
            marsRental.CalculateRentalCost();
            marsRental.PrintRentalSummary();

            // Process payment for the Mars rental
            IPayment marsPayment = new Payment { PaymentMethod = "Interstellar Bank Transfer" };
            marsPayment.ProcessPayment(((Rental)marsRental).TotalCost);
        }
    }
}

// Explanation of OOP Principles Used
//   - Encapsulation: The Rental class encapsulates the logic for
//      calculating rental costs and printing summaries, keeping this
//      logic contained and private to the class.

//   - Abstraction: The IRental and IPayment interfaces abstract rental
//      and payment functionalities, hiding implementation details and focusing on "what" actions are available (renting and paying).
//      Inheritance: LunarShuttle and MarsExplorer inherit from the
//      abstract Spacecraft class, sharing common properties like Name,
//      Capacity, and BaseRentalRate.

//   - Polymorphism: The Spacecraft class’s CalculateRentalPrice method
//      is overridden by each subclass (LunarShuttle and MarsExplorer)
//      to provide different pricing logic based on the spacecraft type.
//      The Payment class also supports multiple payment methods,
//      allowing flexibility in the way payments are processed.
   