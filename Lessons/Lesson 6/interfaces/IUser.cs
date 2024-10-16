//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>16-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_6.Models;

namespace Lesson_6.Interfaces;

/// <summary>
/// Interface User, define contract
/// </summary>
public interface IUser
{
    string FullName { get; set; }
    void BorrowItem(LibraryItem item);
    void ReturnItem(LibraryItem item);
}