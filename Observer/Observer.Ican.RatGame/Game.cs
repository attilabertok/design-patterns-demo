namespace Observer.Ican.RatGame;

/// <summary>
/// The main game class
/// </summary>
/// <remarks>
/// The exercise demands that this class has no fields or properties, only events and methods
/// </remarks>
public class Game
{
    public event EventHandler? RatAdded;

    public event EventHandler? RatRemoved;

    public event EventHandler<int>? RatCountChanged;

    public void AddRat()
    {
        RatAdded?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveRat()
    {
        RatRemoved?.Invoke(this, EventArgs.Empty);
    }

    public void BroadcastRatCount(int newCount)
    {
        RatCountChanged?.Invoke(this, newCount);
    }
}
