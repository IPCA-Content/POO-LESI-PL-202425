//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>09-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_5;

/// <summary>
/// Abstract class Person
/// </summary>
public abstract class Person
{
    #region Private Properties
    private string name { get; set; }
    private int age { get; set; }
    private DateOnly birthDate { get; set; }
    #endregion
    
    #region Public Properties

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return CalculateAge(birthDate); }
    }

    #endregion

    #region Constructors

    /// <summary>
    /// Constructor
    /// </summary>
    public Person()
    {
        age = 0;
        name = "";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="_name"></param>
    /// <param name="_birthDate"></param>
    public Person(string _name, DateOnly _birthDate)
    {
        name = _name;
        birthDate = _birthDate;
    }
    
    #endregion
    
    #region Public Methods

    #endregion

    #region Abstract Methods

    /// <summary>
    /// Returns Values
    /// </summary>
    /// <returns></returns>
    public abstract string ReturnsValues();

    /// <summary>
    /// Calculates age of person
    /// </summary>
    /// <param name="age"></param>
    /// <returns>int</returns>
    public abstract int CalculateAge(DateOnly birthDate);
    #endregion
}