namespace Lesson_9.Interfaces;

public interface IPayment
{
    bool ProcessPayment(decimal amount);
}