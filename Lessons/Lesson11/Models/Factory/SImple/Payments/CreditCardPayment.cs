//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>28-12-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models.Payments;

/// <summary>
/// Class
/// </summary>
public class CreditCardPayment : IPayment
{
    #region Public Methods
    /// <summary>
    /// Process Payment
    /// </summary>
    /// <param name="amount"></param>
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
    #endregion
}