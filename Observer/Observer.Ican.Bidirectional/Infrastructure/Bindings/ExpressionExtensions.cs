using System.Linq.Expressions;
using System.Reflection;

namespace Observer.Ican.Bidirectional.Infrastructure.Bindings;

public static class ExpressionExtensions
{
    public static PropertyInfo? AsPropertyExpression(this Expression<Func<object>> expression)
    {
        return expression.Body is MemberExpression { Member: PropertyInfo propertyInfo }
            ? propertyInfo
            : null;
    }
}
