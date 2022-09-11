namespace Decorator.GoF.Windowing.Components.Base;

public abstract partial class VisualComponentBase :
    IVisualComponent
{
    protected VisualComponentBase(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public int Width { get; private set; } = 40;

    public int InternalWidth { get; protected set; } = 40;

    public int Height { get; private set; } = 15;

    public int InternalHeight { get; protected set; } = 15;

    public abstract void Draw();

    public virtual void Resize(int newWidth, int newHeight, int? internalWidth = null, int? internalHeight = null)
    {
        Width = newWidth;
        Height = newHeight;
        InternalWidth = internalWidth ?? newWidth;
        InternalHeight = internalHeight ?? newHeight;
    }
}
