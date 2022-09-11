namespace Decorator.GoF.Windowing.Components.Base;

public partial interface IVisualComponent
{
    string Name { get; }

    int Width { get; }

    int InternalWidth { get; }

    int Height { get; }

    int InternalHeight { get; }

    void Draw();

    void Resize(int newWidth, int newHeight, int? internalWidth = null, int? internalHeight = null);
}
