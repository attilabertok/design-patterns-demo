using Decorator.GoF.Windowing.Components.Base;
using Decorator.GoF.Windowing.Components.Decorators.Base;
using Decorator.GoF.Windowing.Components.Decorators.Bordering.Helpers;
using Decorator.GoF.Windowing.Infrastructure;
using Decorator.GoF.Windowing.Infrastructure.Factories;
using Decorator.GoF.Windowing.Infrastructure.Glyphs;
using Decorator.GoF.Windowing.Infrastructure.Helpers;

namespace Decorator.GoF.Windowing.Components.Decorators.Bordering;

public class BorderDecorator :
    VisualComponentDecoratorBase
{
    private int sideBorderCount;

    public BorderDecorator(IVisualComponent visualComponent)
        : base(visualComponent, " Bordered")
    {
        var internalWidth = visualComponent.InternalWidth - BorderSize.Width;
        var internalHeight = visualComponent.InternalHeight - BorderSize.Height;
        base.Resize(visualComponent.Width, visualComponent.Height, internalWidth, internalHeight);
        SetSideBorderCount(visualComponent.SideBorderCount);
    }

    public override int SideBorderCount
    {
        get => sideBorderCount;
        set => SetSideBorderCount(value);
    }

    public override void Draw()
    {
        var borders = BorderFactory.CreateLineBorder(Border.Left, Border.Right, SideBorderCount);
        DrawHeader(borders);
        base.Draw();
        DrawFooter(borders);
    }

    public override void Resize(int newWidth, int newHeight, int? internalWidth = null, int? internalHeight = null)
    {
        base.Resize(newWidth, newHeight, internalWidth ?? newWidth - BorderSize.Width, internalHeight ?? newHeight - BorderSize.Height);
    }

    private void DrawHeader(Borders borders)
    {
        var name = TitleHelper.TruncateIfNeeded(TitleHelper.PadIfNeeded(Name, borders), Width, borders);
        var titleLength = TitleHelper.GetTitleLength(name, borders);
        var headerLine = PaddingHelper.AddPadding(name, titleLength, Width);
        Console.WriteLine(BorderHelper.AddBorders(headerLine, borders));
    }

    private void DrawFooter(Borders borders)
    {
        var footerLine = $@"\{new string('-', Width - 2 - borders.Length)}/";
        Console.WriteLine(BorderHelper.AddBorders(footerLine, borders));
    }

    private void SetSideBorderCount(int value)
    {
        sideBorderCount = value;
        VisualComponent.SideBorderCount = value + 1;
    }
}
