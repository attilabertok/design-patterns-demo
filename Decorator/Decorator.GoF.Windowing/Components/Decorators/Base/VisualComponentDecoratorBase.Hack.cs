namespace Decorator.GoF.Windowing.Components.Decorators.Base;

public abstract partial class VisualComponentDecoratorBase
{
    private int sideBorderCount;
    private bool hasVerticalScrollbar;

    /// <remarks>
    /// This is just a simplification artifact for drawing side borders.
    /// In a real implementation this should not exist, and side borders should be taken care of by the border decorator.
    /// </remarks>
    public virtual int SideBorderCount
    {
        get => sideBorderCount;
        set
        {
            sideBorderCount = value;
            VisualComponent.SideBorderCount = value;
        }
    }

    /// <remarks>
    /// This is just a simplification artifact for drawing horizontal scrollbars.
    /// In a real implementation this should not exist, and horizontal scrollbars should be taken care of by the scroll decorator.
    /// </remarks>
    public virtual bool HasVerticalScrollbar
    {
        get => hasVerticalScrollbar;
        set
        {
            hasVerticalScrollbar = value;
            VisualComponent.HasVerticalScrollbar = value;
        }
    }
}
