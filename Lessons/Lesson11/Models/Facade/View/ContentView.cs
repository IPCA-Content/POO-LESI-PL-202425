//-----------------------------------------------------------------

using Lesson10.Interfaces;

namespace Lesson10.Models.Facade.View;

/// <summary>
/// Class
/// </summary>
public class ContentView : IView
{
    #region Public Methods
    public void Render()
    {
        Console.WriteLine("Rendering Content...");
    }
    #endregion
}