namespace Strategy.HeadFirst.Naive.Ducks.Base
{
    public abstract class DuckBase
    {
        public virtual string Quack()
        {
            return "<< Quack! >> - quacking like a duck...";
        }

        public virtual string Swim()
        {
            return "Swimming like a duck...";
        }

        // added recently
        public virtual string Fly()
        {
            return "Flying like a duck...";
        }

        public abstract string Display();
    }
}
