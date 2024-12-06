//-----------------------------------------------------------------

using Lesson11.Interfaces;

namespace Lesson11.Models.Facade.View;

/// <summary>
/// Class
/// </summary>
public class HeaderView : IView
{
    #region Public Properties
    /// <summary>
    /// Render
    /// </summary>
    public void Render()
    {
        Console.WriteLine("Rendering Header...");
    }
    #endregion
}