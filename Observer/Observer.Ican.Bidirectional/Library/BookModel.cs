using Observer.Ican.Bidirectional.Infrastructure.Models;

namespace Observer.Ican.Bidirectional.Library;

public class BookModel : ModelBase
{
    private string title;

    public BookModel(string title)
    {
        this.title = title;
    }

    public string Title
    {
        get => title;
        set => SetField(ref title, value);
    }
}
