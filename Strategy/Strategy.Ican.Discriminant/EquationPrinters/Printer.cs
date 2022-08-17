using System.Text;

namespace Strategy.Ican.Discriminant.EquationPrinters;

public static class Printer
{
    public static string Format(double a, double b, double c)
    {
        var sb = new StringBuilder();
        sb.Append(IsOne(a) ? string.Empty : a)
            .Append(IsZero(a) ? string.Empty : "x^2")
            .Append(GetOperator(b))
            .Append(IsZero(b) || IsOne(b) ? string.Empty : Math.Abs(b))
            .Append(IsZero(b) ? string.Empty : "x")
            .Append(GetOperator(c))
            .Append(IsZero(c) ? string.Empty : Math.Abs(c))
            .Append(" = 0");

        return sb.ToString();
    }

    private static string GetOperator(double value)
    {
        return value switch
        {
            > 0 => " + ",
            < 0 => " - ",
            _ => string.Empty
        };
    }

    private static bool IsOne(double value)
    {
        return Math.Abs(value - 1) < double.Epsilon || Math.Abs(value + 1) < double.Epsilon;
    }

    private static bool IsZero(double value)
    {
        return Math.Abs(value) < double.Epsilon;
    }
}
