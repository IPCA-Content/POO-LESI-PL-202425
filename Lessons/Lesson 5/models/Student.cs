//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>09-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_5.interfaces;
using Utils;

namespace Lesson_5.models;

/// <summary>
/// Class Student that inherits from Person 
/// </summary>
public class Student: Person, ITest
{
    #region Private properties
    
    private string studentId { get; set; }
    private string course { get; set; }
    
    private Date date { get; set; }
    #endregion

    #region Public properties
    public string StudentId { 
        get { return studentId; } 
        set { studentId = value; } 
    }
    
    public string Course { 
        get { return course; } 
        set { course = value; } 
    }
    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// </summary>
    public Student()
    {
        studentId = "";
        course = "";
        date = new Date(); // DLL Class new instance
    }

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="birthDate"></param>
    /// <param name="studentId"></param>
    /// <param name="course"></param>
    public Student(string name, DateOnly birthDate, string studentId, string course)
    : base(name, birthDate)
    {
        this.studentId = studentId;
        this.course = course;
        date = new Date(); // DLL Class new instance
    }
    
    #endregion
    
    #region Public methods

    /// <summary>
    /// Returns All Values 
    /// </summary>
    /// <returns>string</returns>
    public override string ReturnsValues()
    {
        return $"Name: {Name}, age: {Age}, studentId: {StudentId}, course: {Course}";
    }

    /// <summary>
    /// Calculate Age (TPC - DLL) NOT IMPLEMENTED
    /// </summary>
    /// <param name="birthDate"></param>
    /// <returns>int</returns>
    public override int CalculateAge(DateOnly birthDate)
    {
        // reuse the DLL methods here, calling the function
        return date.Age(birthDate);
    }
    
    /// <summary>
    /// Just to implement interface contract
    /// </summary>
    /// <returns>decimal</returns>
    public decimal GetStuff()
    {
        return Age * 100 + 30000; // this is just an example
    }
    #endregion
}