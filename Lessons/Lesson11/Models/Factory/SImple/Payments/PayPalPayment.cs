//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models.Payments;

/// <summary>
/// Class
/// </summary>
public class PayPalPayment : IPayment
{
    #region Public Methods
    /// <summary>
    /// Process Payment
    /// </summary>
    /// <param name="amount"></param>
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
    #endregion
}