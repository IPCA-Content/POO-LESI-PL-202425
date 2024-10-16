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
using Lesson_6.Enums;

namespace Lesson_6.Models;

/// <summary>
/// Abstract Class Library Item and inherits IDisposable from BaseClass 
/// </summary>
public abstract class LibraryItem: BaseClass
{
    #region Private Properties
    private string title { get; set; }
    private string language { get; set; }
    private FormatType format { get; set; }
    private bool taken { get; set; }
    #endregion 
    
    #region Public Properties

    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Language
    {
        get => language;
        set => language = value;
    }

    public FormatType Format
    {
        get => format;
        set => format = value;
    }

    public bool Taken { get => taken; set => taken = value; }
    #endregion
    
    #region Constructors
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="title"></param>
    /// <param name="language"></param>
    /// <param name="format"></param>
    public LibraryItem(string title, string language, FormatType format)
    {
        this.title = title;
        this.language = language;
        this.format = format;
    }
    #endregion

    #region Abstract Methods
    public abstract void GetDetails();

    public abstract bool Contains(List<Author> values);
    #endregion
}