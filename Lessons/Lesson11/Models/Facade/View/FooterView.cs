//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models.Facade.View;

/// <summary>
/// Class
/// </summary>
public class FooterView : IView
{
    #region Public Methods
    /// <summary>
    /// Render
    /// </summary>
    public void Render()
    {
        Console.WriteLine("Rendering Footer...");
    }
    #endregion
}