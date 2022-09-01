using Bogus;

using Observer.Ican.PropertyDependencies.Elections;

namespace Observer.Ican.PropertyDependencies.People.Naive.Factories;

public class PersonFactory
{
    public static Person CreateAdult(DateOnly referenceDate, string? country = null)
    {
        var faker = new Faker();

        var initialDateOfBirth = faker.Person.DateOfBirth;
        var age = referenceDate.ToDateTime(TimeOnly.MinValue) - initialDateOfBirth;
        var ageInYears = age.TotalDays / 365;

        return new Person(
            faker.Person.FullName,
            IsAdult(ageInYears) ? DateOnly.FromDateTime(initialDateOfBirth) : new DateOnly(initialDateOfBirth.Year - Voting.LegalVotingAge, initialDateOfBirth.Month, initialDateOfBirth.Day),
            country ?? faker.Address.Country());
    }

    public static Person CreateChild(DateOnly referenceDate, string? country = null)
    {
        var faker = new Faker();

        var age = faker.Random.Number(0, Voting.LegalVotingAge - 1);

        var dateOfBirth = faker.Person.DateOfBirth;
        var finalDateOfBirth = new DateTime(referenceDate.Year - age, dateOfBirth.Month, dateOfBirth.Day);

        return new Person(
            faker.Person.FullName,
            DateOnly.FromDateTime(finalDateOfBirth),
            country ?? faker.Address.Country());
    }

    private static bool IsAdult(double ageInYears)
    {
        return ageInYears < Voting.LegalVotingAge;
    }
}
