//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>28-12-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson11.Models.Singleton;

/// <summary>
/// Class Singleton
/// </summary>
public class Singleton
{
    #region Private Properties
    /// <summary>
    /// Private Static Property
    /// </summary>
    private static readonly Lazy<Singleton> _instance = 
        new Lazy<Singleton>(() => new Singleton());
    #endregion

    #region Private Constructor
    /// <summary>
    /// Private constructor prevents instantiation from outside the class
    /// </summary>
    private Singleton() { }
    #endregion

    #region Public Properties
    /// <summary>
    /// Public static singleton class instance
    /// </summary>
    public static Singleton Instance => _instance.Value;
    #endregion

    #region Public Methods
    /// <summary>
    /// Do Something
    /// </summary>
    public void DoSomething()
    {
        Console.WriteLine("Singleton instance doing something.");
    }
    #endregion
}
