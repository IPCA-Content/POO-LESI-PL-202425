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
/// Class StaffDiploma Inherit from Diploma
/// </summary>
public class StaffDiploma : Diploma
{
    #region Constructor
    /// <summary>
    /// Constructor Staff Diploma
    /// </summary>
    /// <param name="name"></param>
    /// <param name="admissionDate"></param>
    public StaffDiploma(string name, DateTime admissionDate) : base(name, admissionDate) { }
    #endregion
    
    #region Public Methods
    
    /// <summary>
    /// DisplayInfo method
    /// </summary>
    /// <returns></returns>
    public override string DisplayInfo()
    {
        return $"Staff Diploma - Name: {Name}, Admission Date: {AdmissionDate.ToShortDateString()}";
    }
    #endregion
}