using Observer.Ican.Bidirectional.Infrastructure.Constants;
using Observer.Ican.Bidirectional.Library;
using Observer.Ican.Bidirectional.Library.Naive;

namespace Observer.Ican.Bidirectional;

public static class NaiveImplementation
{
    private static BookModel? bookModel;
    private static NaiveBookViewModel? bookViewModel;

    public static void Demo()
    {
        Initialize();
        Console.WriteLine();

        ChangeInViewModel(Title.Incorrect2);
        Console.WriteLine();

        ChangeInModel(Title.Correct);
        Console.WriteLine();
    }

    private static void Initialize()
    {
        Console.WriteLine("Creating initial model and viewModel...");
        bookModel = new BookModel(Title.Incorrect);
        Console.WriteLine($"Model created, title is '{bookModel.Title}'");
        bookViewModel = new NaiveBookViewModel(bookModel);
        Console.WriteLine($"ViewModel created, title is '{bookViewModel.Title}'");
    }

    private static void ChangeInViewModel(string value)
    {
        Console.WriteLine($"Updating {nameof(NaiveBookViewModel.Title)} in viewModel to {value}...");
        bookViewModel!.Title = value;
        Console.WriteLine("ViewModel updated");
    }

    private static void ChangeInModel(string value)
    {
        Console.WriteLine($"Updating {nameof(BookModel.Title)} in model to {value}...");
        bookModel!.Title = value;
        Console.WriteLine("Model updated");
    }
}
