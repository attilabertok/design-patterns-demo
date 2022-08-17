using Strategy.HeadFirst.Final.Behaviors.Flying.Interface;
using Strategy.HeadFirst.Final.Behaviors.Quacking.Interface;

namespace Strategy.HeadFirst.Final.Ducks.Base
{
    public abstract class DuckBase
    {
        private readonly IQuackBehavior quackBehavior;

        protected DuckBase(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this.quackBehavior = quackBehavior;
            FlyBehavior = flyBehavior;
        }

        public IFlyBehavior FlyBehavior { get; protected set; }

        public string Quack()
        {
            return quackBehavior.Quack();
        }

        public virtual string Swim()
        {
            return "Swimming like a duck...";
        }

        // added recently
        public string Fly()
        {
            return FlyBehavior.Fly();
        }

        public abstract string Display();
    }
}
