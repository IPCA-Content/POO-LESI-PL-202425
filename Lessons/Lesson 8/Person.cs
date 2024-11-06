//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>30-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_8;

[Serializable]
public class Person
{
    #region Public Properties
    public string? Name { get; set; }
    public int Age { get; set; }
    
    [NonSerialized]
    public int Profile;
    #endregion
}