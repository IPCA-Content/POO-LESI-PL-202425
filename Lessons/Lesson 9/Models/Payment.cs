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

namespace Lesson_9.Models;

/// <summary>
/// Class Payment
/// </summary>
public class Payment : IPayment
{
    #region Private Properties
    private string customerId { get; set; } 
    private PaymentMethod paymentMethod { get; set; }
    #endregion
    
    #region Public Properties

    public string CustomerId
    {
        get => customerId; 
        init => customerId = value;
    } 

    public PaymentMethod PaymentMethod
    {
        get => paymentMethod; 
        init => paymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), value.ToString());
    }
    
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// Constructor Payment
    /// </summary>
    /// <param name="customerId"></param>
    /// <param name="paymentMethod"></param>
    public Payment(string customerId, PaymentMethod paymentMethod)
    {
        this.customerId = customerId;
        this.paymentMethod = paymentMethod;
    }

    #endregion
    
    #region Public Methods
    
    /// <summary>
    /// Process Payment
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {PaymentMethod} payment of {amount}€ for customer {CustomerId}");
        return true;
    }
    #endregion
}
