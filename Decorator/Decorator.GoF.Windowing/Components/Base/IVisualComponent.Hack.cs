namespace Decorator.GoF.Windowing.Components.Base;

public partial interface IVisualComponent
{
    /// <remarks>
    /// This is just a simplification artifact for drawing side borders.
    /// In a real implementation this should not exist, and side borders should be taken care of by the border decorator.
    /// </remarks>
    public int SideBorderCount { get; set; }

    /// <remarks>
    /// This is just a simplification artifact for drawing horizontal scrollbars.
    /// In a real implementation this should not exist, and horizontal scrollbars should be taken care of by the scroll decorator.
    /// </remarks>
    public bool HasVerticalScrollbar { get; set; }
}
