namespace vote_counter.Models.Interfaces;

public interface ICandidate
{
    int CandidateId { get; set; }
    string FirstName { get; set; }
    string? LastName { get; set; }
    string? OtherData { get; set; }
}