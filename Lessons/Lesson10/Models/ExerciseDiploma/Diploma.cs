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
/// Abstract Class
/// </summary>
public abstract class Diploma
{
    #region Public Properties
    /// <summary>
    /// Name property
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// AdminssionDate Property
    /// </summary>
    public DateTime AdmissionDate { get; set; }
    #endregion

    #region Constructor
    /// <summary>
    /// Diploma Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="admissionDate"></param>
    public Diploma(string name, DateTime admissionDate)
    {
        Name = name;
        AdmissionDate = admissionDate;
    }
    #endregion

    #region Abstract Methods
    /// <summary>
    /// Abstract Method DisplayInfo
    /// </summary>
    /// <returns></returns>
    public abstract string DisplayInfo();
    #endregion
}