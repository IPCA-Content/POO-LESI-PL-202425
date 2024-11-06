//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_9.Enums;
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
            // Exercício Aula
            // -	Uma empresa de aluguer de naves espaciais permite que os clientes 
            //      aluguem diferentes tipos de naves.
            // -	Cada aluguer calcula o custo total com base no tipo de nave, 
            //      distância até o destino e número de dias.
            // -	O sistema inclui diferentes métodos de pagamento e suporta 
            //      cliente interestelares.
            
            // Or EN
            
            // - A spacecraft rental company allows customers to
            //      rent different types of spacecraft.
            // - Each rental calculates the total cost based on
            //      the type of spacecraft, distance to destination,
            //      and number of days.
            // - The system includes different payment methods
            //      and supports interstellar customers.
            
            #region Usage
            
            // Create customers
            Customer lunarCustomer = new InterstellarCustomer("CUST001", "Neil Armstrong", PaymentMethod.GalacticCredits,0.10m);
            Customer marsCustomer = new Customer("CUST002","Mark Watney", PaymentMethod.InterstellarBankTransfer, CustomerType.Regular);

            // Create spacecrafts for different destinations
            Spacecraft lunarShuttle = new LunarShuttle { Name = "Apollo 11", Capacity = 4, BaseRentalRate = 500m };
            Spacecraft marsExplorer = new MarsExplorer { Name = "Mars Rover", Capacity = 6, BaseRentalRate = 1500m };

            // Rent a lunar shuttle for a 3-day journey to the moon, 238,900 miles away
            IRental lunarRental = new Rental(lunarShuttle, 3, 238900);
            lunarRental.CalculateRentalCost();
            lunarRental.PrintRentalSummary();

            // Process payment for the lunar rental with customer info
            IPayment lunarPayment = new Payment(lunarCustomer.CustomerId, lunarCustomer.PreferredPaymentMethod);
            lunarPayment.ProcessPayment(((Rental)lunarRental).TotalCost);

            Console.WriteLine();

            // Rent a Mars explorer for a 10-day journey to Mars, 225 million miles away
            IRental marsRental = new Rental(marsExplorer, 10, 225000000);
            marsRental.CalculateRentalCost();
            marsRental.PrintRentalSummary();

            // Process payment for the Mars rental with customer info
            IPayment marsPayment = new Payment(marsCustomer.CustomerId, marsCustomer.PreferredPaymentMethod);
            marsPayment.ProcessPayment(((Rental)marsRental).TotalCost);
            #endregion
            
            #region OOP - Object Oriented Principles (Applyed in this example)
            // Explanation of OOP Principles Used
            //   - Encapsulation: The Rental class encapsulates the logic for
            //      calculating rental costs and printing summaries, keeping this
            //      logic contained and private to the class.
            //   - Abstraction: The IRental and IPayment interfaces abstract rental
            //      and payment functionalities, hiding implementation details and focusing
            //      on "what" actions are available (renting and paying).
            //   - Inheritance: LunarShuttle and MarsExplorer inherit from the
            //      abstract Spacecraft class, sharing common properties like Name,
            //      Capacity, and BaseRentalRate.
            //   - Polymorphism: The Spacecraft class’s CalculateRentalPrice method
            //      is overridden by each subclass (LunarShuttle and MarsExplorer)
            //      to provide different pricing logic based on the spacecraft type.
            //      The Payment class also supports multiple payment methods,
            //      allowing flexibility in the way payments are processed.
            #endregion
        }
    }
}
   