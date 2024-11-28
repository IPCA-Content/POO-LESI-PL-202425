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
/// Class TeacherDiploma Inerith from Diploma
/// </summary>
public class TeacherDiploma : Diploma
{
    #region Public Properties
    /// <summary>
    /// Course property
    /// </summary>
    public string Course { get; set; }
    
    /// <summary>
    /// Position roperty
    /// </summary>
    public string Position { get; set; }
    #endregion
    
    #region Constructor
    /// <summary>
    /// Contructor TeacherDiploma
    /// </summary>
    /// <param name="name"></param>
    /// <param name="admissionDate"></param>
    /// <param name="course"></param>
    /// <param name="position"></param>
    public TeacherDiploma(string name, DateTime admissionDate, string course, string position)
        : base(name, admissionDate)
    {
        Course = course;
        Position = position;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// DisplayInfo Method
    /// </summary>
    /// <returns></returns>
    public override string DisplayInfo()
    {
        return $"Teacher Diploma - Name: {Name}, Admission Date: {AdmissionDate.ToShortDateString()}, Course: {Course}, Position: {Position}";
    }
    #endregion
}
