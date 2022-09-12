using System.Text;

using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;
using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators;

public class PinnedShape :
    AbsorbingShapeDecoratorBase<PinnedShape>
{
    public PinnedShape(IShape shape)
        : base(shape)
    {
        IsPinned = true;
    }

    public bool IsPinned { get; set; }

    public override string Draw()
    {
        var sb = new StringBuilder(Shape.Draw());

        if (CanApplyPolicy() && IsPinned)
        {
            sb.Append(" pinned to the top level");
        }

        return sb.ToString();
    }

    public override void Resize(decimal factor) => Shape.Resize(factor);
}
