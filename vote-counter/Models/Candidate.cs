namespace vote_counter.Models;

public class Candidate
{
    public int CandidateId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? OtherData { get; set; }
}