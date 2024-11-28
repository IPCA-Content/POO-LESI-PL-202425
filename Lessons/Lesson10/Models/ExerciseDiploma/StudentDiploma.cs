//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>07-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson10.Models;

/// <summary>
/// Class StudentDiploma inherits from Diploma
/// </summary>
public class StudentDiploma : Diploma
{
    #region Public Properties
    
    /// <summary>
    /// StudentNumber Property
    /// </summary>
    public int StudentNumber { get; set; }
    
    /// <summary>
    /// Course Property
    /// </summary>
    public string Course { get; set; }
    #endregion

    #region Constructor
    /// <summary>
    /// Constructor StudentDiploma
    /// </summary>
    /// <param name="studentNumber"></param>
    /// <param name="name"></param>
    /// <param name="course"></param>
    public StudentDiploma(int studentNumber, string name, string course)
        : base(name, DateTime.Now)
    {
        StudentNumber = studentNumber;
        Course = course;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// DisplayInfo Method
    /// </summary>
    /// <returns></returns>
    public override string DisplayInfo()
    {
        return $"Student Diploma - Student Number: {StudentNumber}, Name: {Name}, Course: {Course}";
    }
    #endregion
}