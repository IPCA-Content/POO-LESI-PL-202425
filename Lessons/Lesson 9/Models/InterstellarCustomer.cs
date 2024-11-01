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

namespace Lesson_9.Models;

/// <summary>
/// Class Interstellar Customer
/// </summary>
public class InterstellarCustomer : Customer
{
    #region Public Properties
    public decimal DiscountRate { get; set; }
    
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// Constructor with args
    /// </summary>
    /// <param name="customerId"></param>
    /// <param name="name"></param>
    /// <param name="preferredPaymentMethod"></param>
    /// <param name="discountRate"></param>

    public InterstellarCustomer(string customerId, string name, PaymentMethod preferredPaymentMethod, decimal discountRate)
        : base(customerId, name, preferredPaymentMethod, CustomerType.Interstellar)
    {
        DiscountRate = discountRate;
    }
    #endregion
}