namespace Strategy.HeadFirst.Inheritance.Ducks.Base
{
    public abstract class DuckBase
    {
        public virtual string Swim()
        {
            return "Swimming like a duck...";
        }

        public abstract string Display();
    }
}
