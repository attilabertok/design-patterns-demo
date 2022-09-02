using System.Linq.Expressions;

namespace Observer.Ican.PropertyDependencies.DependencyManaging.Infrastructure;

public abstract partial class DependencyManagingNotificationBase
{
    private class MemberAccessVisitor : ExpressionVisitor
    {
        private readonly Type declaringType;

        public MemberAccessVisitor(Type declaringType)
        {
            this.declaringType = declaringType;
        }

        public IList<string> PropertyNames { get; } = new List<string>();

        public override Expression? Visit(Expression? node)
        {
            if (node is not null && node.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = (MemberExpression)node;

                if (memberExpression.Member.DeclaringType == declaringType)
                {
                    PropertyNames.Add(memberExpression.Member.Name);
                }
            }

            return base.Visit(node);
        }
    }
}
