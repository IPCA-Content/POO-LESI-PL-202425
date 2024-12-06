//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models;

/// <summary>
/// Class
/// </summary>
public class FileLogger : ILogger
{
    #region Public Methods
    /// <summary>
    /// Log
    /// </summary>
    /// <param name="message"></param>
    public void Log(string message)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}: {message}\n");
    }
    #endregion
}