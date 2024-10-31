using Lesson_9.Interfaces;

namespace Lesson_9.Models;

public class Payment : IPayment
{
    public string PaymentMethod { get; set; }

    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {PaymentMethod} payment of {amount}€");
        return true;
    }
}
