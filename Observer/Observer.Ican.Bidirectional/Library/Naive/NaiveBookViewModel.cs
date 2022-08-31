using System.ComponentModel;

using Observer.Ican.Bidirectional.Infrastructure.ViewModels;

namespace Observer.Ican.Bidirectional.Library.Naive;

public class NaiveBookViewModel
    : ViewModelBase
{
    private readonly BookModel book;
    private string title;

    public NaiveBookViewModel(BookModel book)
    {
        this.book = book;
        book.PropertyChanged += UpdateViewModel;

        title = book.Title;
        PropertyChanged += UpdateModel;
    }

    public string Title
    {
        get => title;
        set => SetField(ref title, value);
    }

    private void UpdateViewModel(object? sender, PropertyChangedEventArgs e)
    {
        Console.WriteLine("Model change detected...");

        if (sender != book)
        {
            throw new ArgumentException("Unexpected sender", nameof(sender));
        }

        if (sender is not BookModel model)
        {
            throw new ArgumentException($"Expected a book, but got a {sender.GetType()}");
        }

        if (e.PropertyName == nameof(BookModel.Title))
        {
            Title = model.Title;
        }
    }

    private void UpdateModel(object? sender, PropertyChangedEventArgs e)
    {
        Console.WriteLine("ViewModel change detected...");

        if (sender != this)
        {
            throw new ArgumentException("Unexpected sender", nameof(sender));
        }

        if (sender is not NaiveBookViewModel viewModel)
        {
            throw new ArgumentException($"Expected a book, but got a {sender.GetType()}");
        }

        if (e.PropertyName == nameof(Title))
        {
            book.Title = viewModel.Title;
        }
    }
}
