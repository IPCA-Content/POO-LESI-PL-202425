//-----------------------------------------------------------------

using Lesson10.Interfaces;

namespace Lesson10.Models;

/// <summary>
/// Class
/// </summary>
public class CloudLogger: ILogger
{
    #region Public Methods
    /// <summary>
    /// Log
    /// </summary>
    /// <param name="message"></param>
    public void Log(string message)
    {
        Console.WriteLine($"This is Cloud Logging service, message: {message}");
    }
    #endregion
}