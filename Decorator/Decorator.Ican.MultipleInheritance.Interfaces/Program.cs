using Bogus;
using Decorator.Ican.MultipleInheritance.Interfaces.Creatures;

namespace Decorator.Ican.MultipleInheritance.Interfaces
{
    public static class Program
    {
        public static void Main()
        {
            DemoBird();
            DemoLizard();
            DemoDragon();
        }

        private static void DemoBird()
        {
            var faker = new Faker();

            var bird = new Bird(faker.Person.LastName)
            {
                Weight = 2,
                Age = 3
            };

            bird.Fly();
        }

        private static void DemoLizard()
        {
            var faker = new Faker();

            var lizard = new Lizard(faker.Person.LastName)
            {
                Weight = 1,
                Age = 5
            };

            lizard.Crawl();
        }

        private static void DemoDragon()
        {
            var faker = new Faker();

            var dragon = new Dragon(faker.Person.LastName)
            {
                Weight = 2500,
                Age = 300
            };

            dragon.Fly();
            dragon.Crawl();
        }
    }
}
