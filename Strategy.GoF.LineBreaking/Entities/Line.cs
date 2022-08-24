namespace Strategy.GoF.LineBreaking.Entities;

public class Line
{
    public Line(decimal targetWidth)
    {
        CurrentWidth = 0;
        TargetWidth = targetWidth;
    }

    public decimal TargetWidth { get; }

    public decimal CurrentWidth { get; private set; }

    public bool HasFreeSpace()
    {
        return CurrentWidth < TargetWidth;
    }

    public bool CanFitElement(decimal elementWidth)
    {
        return CurrentWidth + elementWidth <= TargetWidth;
    }

    public void AddElement(decimal elementWidth)
    {
        CurrentWidth += elementWidth;
    }
}
