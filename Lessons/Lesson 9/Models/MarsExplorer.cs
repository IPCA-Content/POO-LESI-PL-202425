namespace Lesson_9.Models;

public class MarsExplorer : Spacecraft
{
    public override decimal CalculateRentalPrice(int days, double distance)
    {
        // Higher daily rate for longer distances and a premium per-mile cost for Mars
        return (BaseRentalRate * days * 1.5m) + (decimal)(distance * 0.1);
    }
}