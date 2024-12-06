//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models;

/// <summary>
/// Class
/// </summary>
public class ConsoleLogger : ILogger
{
    #region Public Methods
    /// <summary>
    /// Log
    /// </summary>
    /// <param name="message"></param>
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
    #endregion
}