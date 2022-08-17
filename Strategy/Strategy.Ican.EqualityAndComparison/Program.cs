using Strategy.Ican.EqualityAndComparison.People.Factories;

namespace Strategy.Ican.EqualityAndComparison
{
    public static class Program
    {
        public static void Main()
        {
            var people = PersonFactory.Create(5).ToList();

            Console.WriteLine("==== People ordered by name ====");
            people.Sort(Person.NameComparer);
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            Console.WriteLine("==== People ordered by date of birth ====");
            people.Sort(Person.DateOfBirthComparer);
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
