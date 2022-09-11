namespace Decorator.GoF.Windowing.Components.Base;

public abstract partial class VisualComponentBase
{
    /// <inheritdoc />
    public int SideBorderCount { get; set; }

    /// <inheritdoc />
    public bool HasVerticalScrollbar { get; set; }
}
