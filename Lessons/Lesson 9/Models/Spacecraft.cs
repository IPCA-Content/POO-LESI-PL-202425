namespace Lesson_9.Models;

public abstract class Spacecraft
{
    public string Name { get; set; }
    public int Capacity { get; set; } // Number of passengers
    public decimal BaseRentalRate { get; set; }

    // Abstract method for calculating rental price, to be implemented by subclasses
    public abstract decimal CalculateRentalPrice(int days, double distance);
}
