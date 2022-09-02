using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Observer.Ican.PropertyDependencies.Naive.Infrastructure;

public abstract class NaiveNotificationBase :
    INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            Console.WriteLine($"{GetType().Name}:");
            Console.WriteLine($">> Change of '{propertyName}'to the same value ('{value}') discarded");

            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);

        Console.WriteLine($"{GetType().Name}:");
        Console.WriteLine($">> '{propertyName}' is now '{value}'");

        return true;
    }
}
