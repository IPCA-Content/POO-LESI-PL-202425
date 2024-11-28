//-----------------------------------------------------------------

using Lesson10.Enums;
using Lesson10.Interfaces;

namespace Lesson10.Models.Payments;

/// <summary>
/// Class 
/// </summary>
public static class PaymentSimpleFactory
{
    /// <summary>
    /// Using Static Class
    /// A static class in C# cannot be instantiated. It is meant for grouping related
    /// utility methods or factory methods that don’t require creating an object of
    /// the class.
    /// The PaymentFactory is a perfect example of using a static class because:
    ///     - It only provides a factory method CreatePayment.
    ///     - No instance variables or object state are required.
    ///     - It groups related functionality (creating payments) in a single,
    ///     globally accessible location.
    ///     Characteristics of Static Class:
    /// Declared using the static keyword.
    ///     Cannot be instantiated (e.g., new PaymentFactory() is invalid).
    /// All members (fields, methods, properties) must be static.
    /// Typically used for utility/helper classes or factories that do not need to maintain a state.
    ///     Why Use Static Class Here?
    /// The PaymentFactory doesn’t need to store any state; it only provides a single method (CreatePayment).
    /// Makes the code simpler and more efficient since no objects are created unnecessarily.
    /// </summary>
    /// <param name="paymentType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static IPayment CreatePayment(PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.CreditCard => new CreditCardPayment(),
            PaymentType.PayPal => new PayPalPayment(),
            PaymentType.BankTransfer => new BankTransferPayment(),
            _ => throw new ArgumentException("Invalid payment type")
        };
    }
}

/// <summary>
/// Class with a Private Constructor
/// A private constructor prevents the instantiation of a class from outside its definition.
///     Often used in the Singleton Pattern or Factory Pattern where controlled
///     creation of objects is required.
///     Unlike a static class, a class with a private constructor can still have
///     non-static members, which means it can hold state or instance-specific data
///     if an internal instance is created.
/// </summary>
public class PaymentFactory_WithPrivateConstructor
{
    // Private constructor prevents instantiation
    private PaymentFactory_WithPrivateConstructor() { }

    public static IPayment CreatePayment(PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.CreditCard => new CreditCardPayment(),
            PaymentType.PayPal => new PayPalPayment(),
            PaymentType.BankTransfer => new BankTransferPayment(),
            _ => throw new ArgumentException("Invalid payment type")
        };
    }
}