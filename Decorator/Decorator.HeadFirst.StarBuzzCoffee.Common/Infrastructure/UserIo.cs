namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Infrastructure;

public static class UserIo
{
    public static int AskUntilValid(IReadOnlySet<int> validAnswers, string repeatSelectionMessage, Action displayOptions)
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result) && !validAnswers.Contains(result))
        {
            Console.WriteLine(repeatSelectionMessage);
            displayOptions();
        }

        return result;
    }
}
