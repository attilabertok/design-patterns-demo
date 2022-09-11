namespace Decorator.GoF.Windowing.Infrastructure;

public record class Borders(string Left, string Right)
{
    public int Length { get; } = Left.Length + Right.Length;
}
