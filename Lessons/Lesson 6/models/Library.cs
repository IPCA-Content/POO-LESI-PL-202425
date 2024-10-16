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
/// Class Library inherits IDisposable from BaseClass 
/// </summary>
public class Library: BaseClass
{
    #region Private Properties
    private List<LibraryItem> items = [];
    private List<User> users = [];
    #endregion

    #region Public Properties
    public List<LibraryItem> Items
    {
        get => items;
        set => items = value;
    }
    
    public List<User> Users
    {
        get => users;
        set => users.AddRange(value);
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Add Item
    /// </summary>
    /// <param name="item"></param>
    public void AddItem(LibraryItem item)
    {
        Items.Add(item);
        Console.WriteLine($"{item.Title} added to the library.");
    }

    /// <summary>
    /// Register User
    /// </summary>
    /// <param name="user"></param>
    public void RegisterUser(User user)
    {
        if (!Users.Contains(user))
        {
            Users.Add(user);
            Console.WriteLine($"{user.FullName} registered to the library.");    
        }
        else
        {
            Console.WriteLine($"{user.FullName} already registered in the library.");
        }
    }

    /// <summary>
    /// Borrow Item
    /// </summary>
    /// <param name="user"></param>
    /// <param name="item"></param>
    public void BorrowItem(User user, LibraryItem item)
    {
        if (!item.Taken)
        {
            user.BorrowItem(item);
        }
        else
        {
            Console.WriteLine($"'{item.Title}' already borrowed from the library.");
        }
    }

    /// <summary>
    /// Return Item
    /// </summary>
    /// <param name="user"></param>
    /// <param name="item"></param>
    public void ReturnItem(User user, LibraryItem item)
    {
        if (item.Taken)
        {
            user.ReturnItem(item);   
        }
    }

    /// <summary>
    /// List Items
    /// </summary>
    public void ListItems()
    {
        foreach (var item in Items)
        {
            item.GetDetails();
        }
    }
    
    #endregion
}
