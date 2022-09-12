namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

public interface IShape
{
    string Draw();

    void Resize(decimal factor);
}
