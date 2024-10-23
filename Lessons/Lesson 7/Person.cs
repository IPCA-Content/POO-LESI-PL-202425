//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>23-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_7;

/// <summary>
/// Class Person
/// </summary>
public class Person: IComparable
{
    #region Private Properties

    private string name { get; set; }
    private int age { get; set; }
    #endregion
    
    #region Public Properties

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age { get => age; set => age = value; }
    #endregion
    
    #region Constructors

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    #endregion
    
    #region Public Methods
    /// <summary>
    /// Define Compare To method 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public int CompareTo(object? other){   
        if (!(other is Person)) {       
            throw new ArgumentException("Object must be of type Person");      
        }      
        return string.Compare(Name, (other as Person)?.Name, StringComparison.Ordinal);  
    }
    #endregion
}