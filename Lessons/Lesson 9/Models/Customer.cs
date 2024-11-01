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
/// Class cuctomer
/// </summary>
public class Customer
{
    #region Private Properties
    private string customerId { get; set; }
    private string name { get; set; }
    private PaymentMethod preferredPaymentMethod { get; set; }
    
    private CustomerType type { get; set; }

    #endregion
    
    #region Public Properties
    public string CustomerId
    {
        get => customerId;
        init => customerId = value; // init is just teh starting value
    }
    public string Name { get => name; set => name = value; }

    public PaymentMethod PreferredPaymentMethod
    {
        get => preferredPaymentMethod; 
        init => preferredPaymentMethod = value;
    }
    
    // Encapsulated CustomerType with a private setter
    public CustomerType Type { get => type; private set => type = value; }
    #endregion
    
    #region Constructors

    /// <summary>
    /// Empty Constructor
    /// This can be protected, in this case is just
    /// be used in InterstellarCustomer child
    /// </summary>
    protected Customer() 
    {
        customerId = string.Empty;
        name = string.Empty;
        preferredPaymentMethod = PaymentMethod.Undefined;
        type = CustomerType.Regular; // Default type
    }

    /// <summary>
    /// Constructor with args
    /// </summary>
    /// <param name="customerId"></param>
    /// <param name="name"></param>
    /// <param name="preferredPaymentMethod"></param>
    protected Customer(string customerId, string name, PaymentMethod preferredPaymentMethod)
    {
        this.customerId = customerId;
        this.name = name;
        this.preferredPaymentMethod = preferredPaymentMethod;
        type = CustomerType.Regular; // Regular customer by default
    }
    
    /// <summary>
    /// Constructor to set type
    /// </summary>
    /// <param name="customerId"></param>
    /// <param name="name"></param>
    /// <param name="preferredPaymentMethod"></param>
    /// <param name="type"></param>
    public Customer(string customerId, string name, PaymentMethod preferredPaymentMethod, CustomerType type)
    {
        this.customerId = customerId;
        this.name = name;
        this.preferredPaymentMethod = preferredPaymentMethod;
        this.type = type;
    }
    #endregion
}