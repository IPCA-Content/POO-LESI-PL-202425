//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>07-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson10.Models;

/// <summary>
/// Abstract Class BankAccount
/// </summary>
public abstract class BankAccount
{
    #region Protected Properties
    /// <summary>
    /// Balance Property
    /// </summary>
    protected float Balance { get; set; }
    #endregion

    #region Public Properties
    /// <summary>
    /// Constructor BankAccount 
    /// </summary>
    /// <param name="balance"></param>
    public BankAccount(float balance)
    {
        Balance = balance;
    }
    #endregion

    #region Abstract Method
    
    /// <summary>
    /// Calculate Commission Abstract Method
    /// </summary>
    /// <returns></returns>
    public abstract float CalculateCommission();
    #endregion
}