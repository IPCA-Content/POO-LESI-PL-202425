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
/// Class
/// </summary>
public class InvestmentAccount : BankAccount
{
    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="balance"></param>
    public InvestmentAccount(float balance) : base(balance) { }
    #endregion
    
    #region Public Methods
    /// <summary>
    /// Calculate Commission
    /// </summary>
    /// <returns></returns>
    public override float CalculateCommission()
    {
        return Balance * 0.03f;
    }
    #endregion
}
