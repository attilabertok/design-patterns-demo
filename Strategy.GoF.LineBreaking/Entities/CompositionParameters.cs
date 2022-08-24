namespace Strategy.GoF.LineBreaking.Entities;

public class CompositionParameters
{
    public CompositionParameters(Scale naturalSize, Scale stretchability, Scale shrinkability)
    {
        NaturalSize = naturalSize;
        Stretchability = stretchability;
        Shrinkability = shrinkability;
    }

    public Scale NaturalSize { get; }

    public Scale Stretchability { get; }

    public Scale Shrinkability { get; }
}
