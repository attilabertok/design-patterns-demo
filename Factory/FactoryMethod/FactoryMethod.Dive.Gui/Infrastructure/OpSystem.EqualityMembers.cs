namespace FactoryMethod.Dive.Gui.Infrastructure
{
    public sealed partial class OpSystem
    {
        public static bool operator ==(OpSystem? left, OpSystem? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OpSystem? left, OpSystem? right)
        {
            return !Equals(left, right);
        }

        public bool Equals(OpSystem? other)
        {
            return other is not null
                   && (ReferenceEquals(this, other) || Name == other.Name);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj)
                   || (obj is OpSystem other && Equals(other));
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
