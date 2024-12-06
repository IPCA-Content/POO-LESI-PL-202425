//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models;

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