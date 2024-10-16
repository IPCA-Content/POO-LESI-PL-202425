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
using Lesson_6.Interfaces;

namespace Lesson_6.Models;

/// <summary>
/// Class User, using Interface (enforce contract) and inherits IDisposable from BaseClass 
/// </summary>
public abstract class User: BaseClass, IUser
{
    #region Private Properties
    private string fullName { get; set; }
    #endregion
    
    #region Public Properties

    public string FullName
    {
        get => fullName;
        set => fullName = value;
    }

    #endregion
    
    #region Constructors
    
    /// <summary>
    /// Constructors with params
    /// </summary>
    /// <param name="fullName"></param>
    public User(string fullName)
    {
        this.fullName = fullName;
    }
    #endregion
    
    #region Public Methods
    /// <summary>
    /// Borrow Item Method
    /// </summary>
    /// <param name="item"></param>
    public virtual void BorrowItem(LibraryItem item)
    {
        item.Taken = true;
        Console.WriteLine($"{FullName} borrowed {item.Title}");
    }

    /// <summary>
    /// Return Item Method
    /// </summary>
    /// <param name="item"></param>
    public virtual void ReturnItem(LibraryItem item)
    {
        item.Taken = false;
        Console.WriteLine($"{FullName} returned {item.Title}");
    }
    #endregion
}