using Decorator.GoF.Windowing.Components.Base;

namespace Decorator.GoF.Windowing.Components.Decorators.Base;

public abstract partial class VisualComponentDecoratorBase :
    IVisualComponent
{
    protected VisualComponentDecoratorBase(IVisualComponent visualComponent, string name)
    {
        VisualComponent = visualComponent;
        Name = visualComponent.Name + name;
    }

    public string Name { get; protected set; }

    public int Width => VisualComponent.Width;

    public int InternalWidth => VisualComponent.InternalWidth;

    public int Height => VisualComponent.Height;

    public int InternalHeight => VisualComponent.InternalHeight;

    protected IVisualComponent VisualComponent { get; }

    public virtual void Draw()
    {
        VisualComponent.Draw();
    }

    public virtual void Resize(int newWidth, int newHeight, int? internalWidth = null, int? internalHeight = null)
    {
        VisualComponent.Resize(newWidth, newHeight, internalWidth, internalHeight);
    }
}
