//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>16-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_6.Enums;

namespace Lesson_6.Models;

/// <summary>
/// Class Book, inherits LibraryItem
/// </summary>
public class Book: LibraryItem
{
    #region Private Properties
    private List<Author> authors { get; set; }
    private Publisher publisher { get; set; }
    private CategoryType category { get; set; }
    #endregion
    
    #region Public Properties

    public List<Author> Authors
    {
        get => authors;
        set
        {
            if (authors.Any())
            {
                if (!Contains(value))
                {
                    authors.AddRange(value);    
                } 
            }
            else
            {
                authors = value;
            }
        }
    }
    
    public Publisher Publisher
    {
        get => publisher;
        set => publisher = value;
    }

    public CategoryType Category
    {
        get => category;
        set => category = value;
    }

    #endregion

    #region Constructors
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="title"></param>
    /// <param name="language"></param>
    /// <param name="format"></param>
    /// <param name="authors"></param>
    /// <param name="publisher"></param>
    /// <param name="category"></param>
    public Book(string title, string language, FormatType format, List<Author> authors, Publisher publisher, CategoryType category) 
        : base(title, language, format)
    {
        this.authors = authors;
        this.publisher = publisher;
        this.category = category;
    }
    #endregion 
    
    #region Public Methods
    /// <summary>
    /// Get Details
    /// </summary>
    public override void GetDetails()
    {
        Console.WriteLine($"Title: {Title}, Language: {Language}, Format: {Format}, Publisher: {Publisher.Name}, Year: {Publisher.YearOfEdition}, Taken: {Taken}");
    }

    /// <summary>
    /// Check if the author already exists
    /// in the current authors list
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public override bool Contains(List<Author> values)
    {
        foreach (var author in values)
        {
            if (authors.Contains(author))
            {
                return false;
            }
        }
        return false;
    }
    #endregion
}