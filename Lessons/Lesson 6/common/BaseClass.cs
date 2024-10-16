//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>16-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_6.common;

/// <summary>
/// Base class implements IDisposable
/// </summary>
public class BaseClass: IDisposable
{
    #region IDisposable implementation
    /// <summary>
    /// Dispose with Garbage collect
    /// </summary>
    public void Dispose()
    {
        Console.WriteLine("BaseClass Dispose called. Shared cleanup.");
        GC.SuppressFinalize(this); // Prevents the destructor from running
    }
    #endregion

    #region Destructor
    /// <summary>
    /// Destructor, will only be called if Dispose isn't called
    /// </summary>
    ~BaseClass()
    {
        Console.WriteLine("BaseClass destructor called.");
    }
    #endregion
}