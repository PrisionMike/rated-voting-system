namespace vote_counter.Models;

public class Vote
{
    public int VoteId { get; set; }
    public int Candidate1 { get; set; }
    public int Candidate2 { get; set; }
    public int Candidate3 { get; set; }
    public int Candidate4 { get; set; }
    public int ElectionId { get; set; }
    public DateTime Timestamp { get; set; }
}