using Observer.Ican.Bidirectional.Infrastructure.Constants;
using Observer.Ican.Bidirectional.Library;
using Observer.Ican.Bidirectional.Library.Bound;

namespace Observer.Ican.Bidirectional;

public static class BindingImplementation
{
    private static BookModel? bookModel;
    private static BoundBookViewModel? bookViewModel;

    public static void Demo()
    {
        Initialize();
        Console.WriteLine();

        ChangeInViewModel(Title.Incorrect2);
        Console.WriteLine();

        ChangeInModel(Title.Correct);
        Console.WriteLine();

        Console.WriteLine("Breaking binding...");
        bookViewModel!.BreakBinding();
        ChangeInViewModel(Title.Incorrect2);
        Console.WriteLine($"'{nameof(BookModel.Title)}' in model is '{bookModel!.Title}'");
        ChangeInModel(Title.Incorrect);
        Console.WriteLine($"'{nameof(BoundBookViewModel.Title)}' in viewModel is '{bookViewModel.Title}'");
    }

    private static void Initialize()
    {
        Console.WriteLine("Creating initial model and viewModel...");
        bookModel = new BookModel(Title.Incorrect);
        Console.WriteLine($"Model created, title is '{bookModel.Title}'");
        bookViewModel = new BoundBookViewModel(bookModel);
        Console.WriteLine($"ViewModel created, title is '{bookViewModel.Title}'");
    }

    private static void ChangeInViewModel(string value)
    {
        Console.WriteLine($"Updating {nameof(BoundBookViewModel.Title)} in viewModel to {value}...");
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
