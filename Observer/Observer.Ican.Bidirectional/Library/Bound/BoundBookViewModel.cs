using Observer.Ican.Bidirectional.Infrastructure.Bindings;
using Observer.Ican.Bidirectional.Infrastructure.ViewModels;

namespace Observer.Ican.Bidirectional.Library.Bound;

public class BoundBookViewModel :
    ViewModelBase
{
    private readonly BookModel book;
    private readonly IDisposable binding;

    private string title;

    public BoundBookViewModel(BookModel book)
    {
        this.book = book;
        title = book.Title;
        binding = new BidirectionalBinding(book, () => book.Title, this, () => Title);
    }

    public string Title
    {
        get => title;
        set => SetField(ref title, value);
    }

    public void BreakBinding()
    {
        binding.Dispose();
    }
}
