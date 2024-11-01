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
/// Class Spacecraft
/// </summary>
public abstract class Spacecraft
{
    #region Public Properties
    public string? Name { get; init; }
    public int Capacity { get; set; } // Number of passengers
    public decimal BaseRentalRate { get; init; }

    #endregion

    #region Abstract methods
    /// <summary>
    /// Abstract method for calculating rental price,
    /// to be implemented by subclasses
    /// </summary>
    /// <param name="days"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    public abstract decimal CalculateRentalPrice(int days, double distance);
    #endregion
}
