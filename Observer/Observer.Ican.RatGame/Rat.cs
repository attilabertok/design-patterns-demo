namespace Observer.Ican.RatGame;

public class Rat : IDisposable
{
    /// <summary>
    /// Attack value of a rat
    /// </summary>
    /// <remarks>
    /// The exercise demands this to be a public field instead of a property
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "StyleCop.CSharp.MaintainabilityRules",
        "SA1401:Fields should be private",
        Justification = "Limitation of the exercise")]
    public int Attack = 1;

    private readonly Game game;

    public Rat(Game game)
    {
        this.game = game;
        game.RatCountChanged += GameOnRatCountChanged;
        game.AddRat();

        game.RatAdded += (_, _) => IncreaseRatStats();
        game.RatRemoved += (_, _) => DecreaseRatStats();
    }

    public void Dispose()
    {
        game.RemoveRat();
    }

    private void UpdateStats(int newAttack)
    {
        Attack = newAttack;
        game.RatCountChanged -= GameOnRatCountChanged;
    }

    private void GameOnRatCountChanged(object? sender, int newRatCount)
    {
        UpdateStats(newRatCount);
    }

    private void IncreaseRatStats()
    {
        Attack++;
        game.BroadcastRatCount(Attack);
    }

    private void DecreaseRatStats()
    {
        Attack--;
        game.BroadcastRatCount(Attack);
    }
}
