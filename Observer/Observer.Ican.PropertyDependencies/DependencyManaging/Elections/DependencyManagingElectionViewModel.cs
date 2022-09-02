using Observer.Ican.PropertyDependencies.CommonInfrastructure;
using Observer.Ican.PropertyDependencies.DependencyManaging.Infrastructure.ViewModels;
using Observer.Ican.PropertyDependencies.DependencyManaging.People;

namespace Observer.Ican.PropertyDependencies.DependencyManaging.Elections;

public class DependencyManagingElectionViewModel
    : ViewModelBase
{
    private readonly Func<bool> isCitizen;
    private readonly Func<int?> voterAge;
    private readonly Func<bool> isVoterEligibleToVote;

    private string country;
    private DateOnly date;
    private string? voterNationality;
    private DateOnly? voterDateOfBirth;
    private Person? voter;

    public DependencyManagingElectionViewModel(Election election)
    {
        country = election.Country;
        date = election.Date;

        isCitizen = Property(nameof(IsCitizen), () => string.Equals(Country, VoterNationality, StringComparison.InvariantCultureIgnoreCase));
        voterAge = Property(nameof(VoterAge), () => VoterDateOfBirth.HasValue ? (int?)Date.Year - VoterDateOfBirth.Value.Year : null);
        isVoterEligibleToVote = Property(nameof(IsVoterEligibleToVote), () => IsOverVotingAge() && IsCitizen);
    }

    public string Country
    {
        get => country;
        set => SetField(ref country, value);
    }

    public DateOnly Date
    {
        get => date;
        set => SetField(ref date, value);
    }

    public DateOnly? VoterDateOfBirth
    {
        get => voterDateOfBirth;
        set => SetField(ref voterDateOfBirth, value);
    }

    public string? VoterNationality
    {
        get => voterNationality;
        private set => SetField(ref voterNationality, value);
    }

    public bool IsCitizen => isCitizen();

    public int? VoterAge => voterAge();

    public bool IsVoterEligibleToVote => isVoterEligibleToVote();

    public Person? Voter
    {
        get => voter;
        set
        {
            if (SetField(ref voter, value) && value is not null)
            {
                VoterDateOfBirth = value.DateOfBirth;
                VoterNationality = value.Nationality;
            }
        }
    }

    public void PrintData()
    {
        Console.WriteLine($"{Voter!.Name} is a citizen of {Voter!.Nationality}, born on {Voter!.DateOfBirth}.");
        Console.WriteLine($"On election day, {Voter!.Name} is {VoterAge} years old, and is {(IsCitizen ? string.Empty : "not ")}a citizen of {Country}");
        Console.WriteLine($"Based on this data, {Voter!.Name} can {(IsVoterEligibleToVote ? string.Empty : "not ")}vote during the elections.");
    }

    private bool IsOverVotingAge()
    {
        return VoterAge > Voting.LegalVotingAge;
    }
}
