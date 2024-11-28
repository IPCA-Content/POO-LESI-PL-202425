//-----------------------------------------------------------------

using Lesson10.Interfaces;

namespace Lesson10.Models;

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