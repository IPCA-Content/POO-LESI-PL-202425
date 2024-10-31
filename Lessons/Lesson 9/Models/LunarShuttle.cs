namespace Lesson_9.Models;

public class LunarShuttle : Spacecraft
{
    public override decimal CalculateRentalPrice(int days, double distance)
    {
        // Fixed daily rate for lunar travel with additional per-mile cost
        return (BaseRentalRate * days) + (decimal)(distance * 0.05);
    }
}
