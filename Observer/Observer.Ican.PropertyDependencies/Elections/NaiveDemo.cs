using Bogus;

using Observer.Ican.PropertyDependencies.Elections.Factories;
using Observer.Ican.PropertyDependencies.Elections.Naive;
using Observer.Ican.PropertyDependencies.People.Naive.Factories;

using Person = Observer.Ican.PropertyDependencies.People.Naive.Person;

namespace Observer.Ican.PropertyDependencies.Elections;

public class NaiveDemo
{
    public static void Execute()
    {
        var faker = new Faker();
        var country = faker.Address.Country();
        var otherCountry = faker.Address.Country();
        var election = ElectionFactory.Create(country);
        Console.WriteLine($"Elections are held in {country} on {election.Date}, the legal voting age is {Voting.LegalVotingAge}.");

        var eligiblePerson = PersonFactory.CreateAdult(election.Date, country);

        var electionViewModel = new NaiveElectionViewModel(election)
        {
            Voter = eligiblePerson
        };
        electionViewModel.PrintData();
        Console.WriteLine();

        var nonCitizen = PersonFactory.CreateAdult(election.Date, otherCountry);
        electionViewModel.Voter = nonCitizen;
        electionViewModel.PrintData();
        Console.WriteLine();

        var eligiblePerson2 = PersonFactory.CreateAdult(election.Date, country);
        electionViewModel.Voter = eligiblePerson2;
        electionViewModel.PrintData();
        Console.WriteLine();

        var child = PersonFactory.CreateChild(election.Date, country);
        electionViewModel.Voter = child;
        electionViewModel.PrintData();
        Console.WriteLine();
    }
}
