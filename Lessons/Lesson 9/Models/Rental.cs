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

namespace Lesson_9.Models;

/// <summary>
/// Class Rental
/// </summary>
public class Rental : IRental
{
    #region Private Properties
    private Spacecraft spacecraft { get; set; }
    private int rentalDays { get; set; }
    private double distanceToDestination { get; set; }
    private decimal totalCost { get; set; }
    #endregion
    
    #region Public Properties

    public Spacecraft Spacecraft
    {
        get => spacecraft; 
        set => spacecraft = value;
    }

    public int RentalDays
    {
        get => rentalDays; 
        set => rentalDays = value;
    }

    public double DistanceToDestination
    {
        get => distanceToDestination; 
        set => distanceToDestination = value;
    }

    public decimal TotalCost
    {
        get => totalCost; 
        private set => totalCost = value;
    }
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// Constructor with args
    /// </summary>
    /// <param name="spacecraft"></param>
    /// <param name="rentalDays"></param>
    /// <param name="distance"></param>
    public Rental(Spacecraft spacecraft, int rentalDays, double distance)
    {
        this.spacecraft = spacecraft;
        this.rentalDays = rentalDays;
        distanceToDestination = distance;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Calculate Rental Cost
    /// </summary>
    public void CalculateRentalCost()
    {
        totalCost = Spacecraft.CalculateRentalPrice(RentalDays, DistanceToDestination);
    }

    /// <summary>
    /// Print Rental Summary
    /// </summary>
    public void PrintRentalSummary()
    {
        Console.WriteLine($"Spacecraft: {Spacecraft.Name}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Distance: {DistanceToDestination} km");
        Console.WriteLine($"Total Cost: {TotalCost}€");
    }
    #endregion
}
