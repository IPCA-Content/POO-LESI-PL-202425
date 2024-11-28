//-----------------------------------------------------------------

using Lesson10.Interfaces;

namespace Lesson10.Models;

/// <summary>
/// Class
/// </summary>
public class ReportGenerator
{
    #region Private Properties
    /// <summary>
    /// ILogger Private property
    /// </summary>
    private readonly ILogger _logger;
    #endregion

    #region Constructor
    /// <summary>
    /// Constructor injection
    /// </summary>
    /// <param name="logger"></param>
    public ReportGenerator(ILogger logger)
    {
        _logger = logger;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Generate Report
    /// </summary>
    public void GenerateReport()
    {
        _logger.Log("Generating report...");
        // Logic to generate report
        _logger.Log("Report generated.");
    }
    #endregion
}