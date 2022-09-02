using Observer.Ican.PropertyDependencies.CommonInfrastructure;
using Observer.Ican.PropertyDependencies.Naive.Infrastructure.ViewModels;
using Observer.Ican.PropertyDependencies.Naive.People;

namespace Observer.Ican.PropertyDependencies.Naive.Elections;

public class NaiveElectionViewModel
    : NaiveViewModelBase
{
    private string country;
    private DateOnly date;
    private string? voterNationality;
    private DateOnly? voterDateOfBirth;
    private Person? voter;

    public NaiveElectionViewModel(Election election)
    {
        country = election.Country;
        date = election.Date;
    }

    public string Country
    {
        get => country;
        set
        {
            if (SetField(ref country, value))
            {
                // dependent property needs to be changed
                // dependency on Election.Country is difficult to express
                OnPropertyChanged(nameof(IsVoterEligibleToVote));
                OnPropertyChanged(nameof(IsCitizen));
            }
        }
    }

    public DateOnly Date
    {
        get => date;
        set
        {
            if (SetField(ref date, value))
            {
                // dependent properties need to be changed - does not scale
                // dependency on Election.Date is difficult to express
                OnPropertyChanged(nameof(VoterAge));
                OnPropertyChanged(nameof(IsVoterEligibleToVote));
            }
        }
    }

    public DateOnly? VoterDateOfBirth
    {
        get => voterDateOfBirth;
        set
        {
            if (SetField(ref voterDateOfBirth, value))
            {
                // dependent properties need to be changed - does not scale
                // dependency on Voter.DateOfBirth is difficult to express
                OnPropertyChanged(nameof(VoterAge));
                OnPropertyChanged(nameof(IsVoterEligibleToVote));
            }
        }
    }

    public string? VoterNationality
    {
        get => voterNationality;
        private set
        {
            if (SetField(ref voterNationality, value))
            {
                // dependent property needs to be changed
                // dependency on Voter.Nationality is difficult to express
                OnPropertyChanged(nameof(IsVoterEligibleToVote));
                OnPropertyChanged(nameof(IsCitizen));
            }
        }
    }

    public bool IsCitizen => string.Equals(Country, VoterNationality, StringComparison.InvariantCultureIgnoreCase);

    public int? VoterAge => VoterDateOfBirth.HasValue
        ? Date.Year - VoterDateOfBirth.Value.Year
        : null;

    public bool IsVoterEligibleToVote => IsOverVotingAge() && IsCitizen;

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
