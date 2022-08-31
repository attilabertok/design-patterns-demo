using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Observer.Ican.Bidirectional.Infrastructure.Bindings;

public sealed class BidirectionalBinding : IDisposable
{
    private bool isDisposed;

    public BidirectionalBinding(
        INotifyPropertyChanged source,
        Expression<Func<object>> sourceProperty,
        INotifyPropertyChanged destination,
        Expression<Func<object>> destinationProperty)
    {
        var sourceExpression = sourceProperty.AsPropertyExpression();
        var destinationExpression = destinationProperty.AsPropertyExpression();

        if (AreValid(sourceExpression, destinationExpression))
        {
            source.PropertyChanged += (_, _) => Update(source, sourceExpression!, destination, destinationExpression!);
            destination.PropertyChanged += (_, _) => Update(destination, destinationExpression!, source, sourceExpression!);
        }

        isDisposed = false;
    }

    public void Dispose()
    {
        isDisposed = true;
    }

    private static bool AreValid(PropertyInfo? sourceExpression, PropertyInfo? destinationExpression)
    {
        return PropertyValidator.IsValid(sourceExpression)
               && PropertyValidator.IsValid(destinationExpression);
    }

    private void Update(
        INotifyPropertyChanged source,
        PropertyInfo sourceProperty,
        INotifyPropertyChanged destination,
        PropertyInfo destinationProperty)
    {
        if (!isDisposed)
        {
            destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
        }
    }
}
