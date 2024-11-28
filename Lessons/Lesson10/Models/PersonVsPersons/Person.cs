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

/// <summary>
/// Class Person
/// </summary>
public class Person
{
    #region Public Properties
    public string Name { get; set; }
    public int Age { get; set; }
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Greet
    /// </summary>
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}, and I am {Age} years old.");
    }
    #endregion
}
