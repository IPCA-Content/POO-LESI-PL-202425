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
/// Class Author, inherits IDisposable from BaseClass 
/// </summary>
public class Author: BaseClass
{
    #region Private Properties
    private string name { get; set; }
    #endregion
    
    #region Public Properties

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    #endregion
    
    #region Constructors
    public Author(string name)
    {
        this.name = name;
    }
    #endregion
}