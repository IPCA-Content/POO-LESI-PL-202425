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

namespace Lesson_5;

/// <summary>
/// Class Student that inherits from Person 
/// </summary>
public class Student: Person, ITest
{
    #region Private properties
    
    public string studentId { get; set; }
    public string course { get; set; }
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
        
    }

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="_name"></param>
    /// <param name="_birthDate"></param>
    /// <param name="_studentId"></param>
    /// <param name="_course"></param>
    public Student(string _name, DateOnly _birthDate, string _studentId, string _course)
    : base(_name, _birthDate)
    {
        studentId = _studentId;
        course = _course;
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
        // use the DLL here, call the function
        return 0;
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