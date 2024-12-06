using Lesson11.Interfaces;

namespace Lesson11.Models.Facade.View;

public class PageRenderer
{
    private readonly IView _headerView;
    private readonly IView _contentView;
    private readonly IView _footerView;

    public PageRenderer(IView headerView, IView contentView, IView footerView)
    {
        _headerView = headerView;
        _contentView = contentView;
        _footerView = footerView;
    }

    public void RenderPage()
    {
        Console.WriteLine("Starting page rendering...");

        _headerView.Render();
        _contentView.Render();
        _footerView.Render();

        Console.WriteLine("Page rendering complete.");
    }
}
