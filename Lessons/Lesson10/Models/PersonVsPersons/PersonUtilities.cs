//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson10.Models.PersonVsPersons;

using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Utilities
/// </summary>
public static class PersonUtilities
{
    #region Utilities
    /// <summary>
    /// Static method to find the oldest person
    /// </summary>
    /// <param name="people"></param>
    /// <returns></returns>
    public static Person FindOldestPerson(List<Person> people)
    {
        return people.OrderByDescending(p => p.Age).FirstOrDefault();
    }

    /// <summary>
    /// Static method to calculate average age
    /// </summary>
    /// <param name="people"></param>
    /// <returns></returns>
    public static double CalculateAverageAge(List<Person> people)
    {
        return people.Average(p => p.Age);
    }
    #endregion
}
