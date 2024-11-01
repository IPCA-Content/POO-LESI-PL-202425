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
/// Class Lunar Shuttle
/// </summary>
public class LunarShuttle : Spacecraft
{
    #region Public Methods
    /// <summary>
    /// Calculate Rental Price
    /// </summary>
    /// <param name="days"></param>
    /// <param name="distance"></param>
    /// <returns>decimal</returns>
    public override decimal CalculateRentalPrice(int days, double distance)
    {
        // Fixed daily rate for lunar travel with additional per-mile cost
        return (BaseRentalRate * days) + (decimal)(distance * 0.05);
    }
    #endregion
}
