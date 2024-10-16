//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>16-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_6.Models;

/// <summary>
/// Class Professor that inherits from User
/// </summary>
public class Professor: User
{
    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="fullName"></param>
    public Professor(string fullName) : base(fullName) { }
    #endregion
}