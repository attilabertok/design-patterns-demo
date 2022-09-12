using Decorator.Ican.Composition.Dynamic.Drawing.Shapes;
using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators;
using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic
{
    public static class Program
    {
        private const decimal Factor = 1.2m;

        public static void Main()
        {
            var square = new Square(1.23m);
            Console.WriteLine(square.Draw());
            Resize(square);

            var coloredSquare = new ColoredShape(square, "blue");
            coloredSquare.Draw();
            Resize(coloredSquare);

            var transparentColoredSquare = new TransparentShape(coloredSquare, 0.7m);
            transparentColoredSquare.Draw();
            Resize(transparentColoredSquare);

            var doubleTransparentColoredSquare = new TransparentShape(transparentColoredSquare, 0.3m);
            doubleTransparentColoredSquare.Draw();
            Resize(doubleTransparentColoredSquare);

            var circle = new Circle(2.34m);
            Console.WriteLine(circle.Draw());
            Resize(circle);

            var coloredCircle = new ColoredShape(circle, "red");
            coloredCircle.Draw();
            Resize(coloredCircle);

            var transparentColoredCircle = new TransparentShape(coloredCircle, 0.7m);
            transparentColoredCircle.Draw();
            Resize(transparentColoredCircle);

            try
            {
                var doubleColoredCircle = new ColoredShape(transparentColoredCircle, "green");
                doubleColoredCircle.Draw();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            var pinnedTransparentColoredCircle = new PinnedShape(transparentColoredCircle);
            pinnedTransparentColoredCircle.Draw();
            Resize(pinnedTransparentColoredCircle);

            var doublePinnedTransparentColoredCircle = new PinnedShape(pinnedTransparentColoredCircle);
            doublePinnedTransparentColoredCircle.Draw();
            Resize(doublePinnedTransparentColoredCircle);
        }

        private static void Resize(IShape shape)
        {
            Console.WriteLine($"Resizing, factor: {Factor}");
            shape.Resize(Factor);
            Console.WriteLine(shape.Draw());
        }
    }
}
