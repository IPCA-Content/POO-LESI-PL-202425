//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>16-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_6.common;

namespace Lesson_6.Models;

/// <summary>
/// Class Publisher, inherits IDisposable from BaseClass 
/// </summary>
public class Publisher: BaseClass
{
    #region Private Properties
    private string name { get; set; }
    private int yearOfEdition { get; set; }
    #endregion
    
    #region Public Properties

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int YearOfEdition
    {
        get => yearOfEdition;
        set => yearOfEdition = value;
    }

    #endregion

    #region Constructors
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="yearOfEdition"></param>
    public Publisher(string name, int yearOfEdition)
    {
        this.name = name;
        this.yearOfEdition = yearOfEdition;
    }
    #endregion
}
