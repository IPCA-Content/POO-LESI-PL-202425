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

using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Class
/// </summary>
public class Persons
{
    #region Private Properties
    /// <summary>
    /// List Persons
    /// </summary>
    private readonly List<Person?> _people = [];
    #endregion

    #region Public Properties
    /// <summary>
    /// Add Person
    /// </summary>
    /// <param name="person"></param>
    public void AddPerson(Person? person)
    {
        _people.Add(person);
    }

    /// <summary>
    /// Remove Person
    /// </summary>
    /// <param name="person"></param>
    public void RemovePerson(Person? person)
    {
        _people.Remove(person);
    }

    /// <summary>
    /// Find Person By Name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Person? FindPersonByName(string name)
    {
        return _people.FirstOrDefault(p => p?.Name == name);
    }

    /// <summary>
    /// Introduce Everyone
    /// </summary>
    public void IntroduceEveryone()
    {
        foreach (var person in _people)
        {
            person?.Greet();
        }
    }

    /// <summary>
    /// Get All People
    /// </summary>
    /// <returns></returns>
    public List<Person> GetAllPeople()
    {
        // return new List<Person>(_people);
        return [.._people];
    }
    #endregion
}
