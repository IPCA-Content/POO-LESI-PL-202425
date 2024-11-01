//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_9.Models;

/// <summary>
/// Mars Explorer
/// </summary>
public class MarsExplorer : Spacecraft
{
    #region Public Methods
    /// <summary>
    /// Calculate Rental Price
    /// </summary>
    /// <param name="days"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    public override decimal CalculateRentalPrice(int days, double distance)
    {
        // Higher daily rate for longer distances and a premium per-mile cost for Mars
        return (BaseRentalRate * days * 1.5m) + (decimal)(distance * 0.1);
    }
    #endregion
}