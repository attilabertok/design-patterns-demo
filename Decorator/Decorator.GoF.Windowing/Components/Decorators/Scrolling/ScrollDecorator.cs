using Decorator.GoF.Windowing.Components.Base;
using Decorator.GoF.Windowing.Components.Decorators.Base;
using Decorator.GoF.Windowing.Infrastructure.Factories;
using Decorator.GoF.Windowing.Infrastructure.Glyphs;
using Decorator.GoF.Windowing.Infrastructure.Helpers;

namespace Decorator.GoF.Windowing.Components.Decorators.Scrolling;

public class ScrollDecorator :
    VisualComponentDecoratorBase
{
    private bool hasVerticalScrollbar;

    public ScrollDecorator(IVisualComponent visualComponent)
        : base(visualComponent, " Scrollable")
    {
        base.Resize(visualComponent.Width, visualComponent.Height, visualComponent.InternalWidth - 3, visualComponent.InternalHeight - 1);
        visualComponent.HasVerticalScrollbar = true;
    }

    public override bool HasVerticalScrollbar
    {
        get => hasVerticalScrollbar;
        set
        {
            hasVerticalScrollbar = value;
            VisualComponent.HasVerticalScrollbar = value;
        }
    }

    public override void Draw()
    {
        base.Draw();
        DrawHorizontalScrollBar();
    }

    public override void Resize(int newWidth, int newHeight, int? internalWidth = null, int? internalHeight = null)
    {
        base.Resize(newWidth, newHeight, internalWidth ?? newWidth - 3, internalHeight ?? newHeight - 1);
    }

    private void DrawHorizontalScrollBar()
    {
        var scrollBar = $"<|{new string('=', InternalWidth - 2)}>  ";
        scrollBar = BorderHelper.AddBorders(scrollBar, BorderFactory.CreateLineBorder(Border.Left, Border.Right, SideBorderCount));
        Console.WriteLine(scrollBar);
    }
}
