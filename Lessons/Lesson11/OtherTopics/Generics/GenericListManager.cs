//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>28-12-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson11.OtherTopics.Generics;

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// A generic class to manage lists of items of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of items to manage, constrained to be a reference type.</typeparam>
[CLSCompliant(true)]
public class ListManager<T> where T : class
{
    #region Fields
    /// <summary>
    /// Internal list to store items.
    /// </summary>
    private readonly List<T> _items;
    #endregion

    #region Constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="ListManager{T}"/> class.
    /// </summary>
    public ListManager()
    {
        _items = new List<T>();
    }
    #endregion

    #region Methods
    /// <summary>
    /// Adds an item to the list.
    /// </summary>
    /// <param name="item">The item to add.</param>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="item"/> is null.</exception>
    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }
        _items.Add(item);
    }

    /// <summary>
    /// Removes an item from the list.
    /// </summary>
    /// <param name="item">The item to remove.</param>
    /// <returns>True if the item was successfully removed; otherwise, false.</returns>
    public bool Remove(T item)
    {
        return _items.Remove(item);
    }

    /// <summary>
    /// Gets all items in the list as a read-only collection.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> containing all items in the list.</returns>
    public IEnumerable<T> GetAll()
    {
        return _items.AsReadOnly();
    }

    /// <summary>
    /// Finds items in the list that match a specified condition.
    /// </summary>
    /// <param name="predicate">A function that defines the condition to match.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> containing the matched items.</returns>
    public IEnumerable<T> Find(Func<T, bool> predicate)
    {
        return _items.Where(predicate);
    }

    /// <summary>
    /// Clears all items from the list.
    /// </summary>
    public void Clear()
    {
        _items.Clear();
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets the number of items in the list.
    /// </summary>
    public int Count => _items.Count;
    #endregion
}
