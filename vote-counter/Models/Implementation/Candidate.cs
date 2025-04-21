using vote_counter.Models.Interfaces;

namespace vote_counter.Models.Implementation;

public class Candidate : ICandidate
{
    public int CandidateId { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? OtherData { get; set; }
}