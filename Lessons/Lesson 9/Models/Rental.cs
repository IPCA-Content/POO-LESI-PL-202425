using Lesson_9.Interfaces;

namespace Lesson_9.Models;

public class Rental : IRental
{
    public Spacecraft Spacecraft { get; set; }
    public int RentalDays { get; set; }
    public double DistanceToDestination { get; set; } // Distance in light-miles
    public decimal TotalCost { get; private set; }

    public Rental(Spacecraft spacecraft, int rentalDays, double distance)
    {
        Spacecraft = spacecraft;
        RentalDays = rentalDays;
        DistanceToDestination = distance;
    }

    public void CalculateRentalCost()
    {
        TotalCost = Spacecraft.CalculateRentalPrice(RentalDays, DistanceToDestination);
    }

    public void PrintRentalSummary()
    {
        Console.WriteLine($"Spacecraft: {Spacecraft.Name}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Distance: {DistanceToDestination} km");
        Console.WriteLine($"Total Cost: {TotalCost}€");
    }
}
