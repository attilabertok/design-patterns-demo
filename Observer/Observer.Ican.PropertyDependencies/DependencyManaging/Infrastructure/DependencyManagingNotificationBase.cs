using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Observer.Ican.PropertyDependencies.DependencyManaging.Infrastructure;

public abstract partial class DependencyManagingNotificationBase :
    INotifyPropertyChanged
{
    private readonly Dictionary<string, HashSet<string>> affectedProperties = new();

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        NotifyDependentProperties(propertyName);
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

    protected Func<T> Property<T>(string name, Expression<Func<T>> expr)
    {
        Console.WriteLine($"Creating computed property for {name}");

        var visitor = new MemberAccessVisitor(GetType());
        visitor.Visit(expr);

        if (visitor.PropertyNames.Any())
        {
            AddDependentProperty(name, visitor.PropertyNames);
        }

        return expr.Compile();
    }

    private void AddDependentProperty(string name, IEnumerable<string> propertyNames)
    {
        foreach (var propertyName in propertyNames)
        {
            if (!affectedProperties.ContainsKey(propertyName))
            {
                affectedProperties.Add(propertyName, new HashSet<string>());
            }

            if (propertyName != name)
            {
                affectedProperties[propertyName].Add(name);
            }
        }
    }

    private void NotifyDependentProperties(string? propertyName)
    {
        if (affectedProperties.TryGetValue(propertyName!, out var dependentProperties))
        {
            foreach (var property in dependentProperties)
            {
                // TODO: only notify if property value is actually changed
                OnPropertyChanged(property);
            }
        }
    }
}
