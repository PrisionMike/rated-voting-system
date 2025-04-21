using vote_counter.Models.Interfaces;

namespace vote_counter.Models.Implementation;

public class Ballot : IBallot
{
    public int Id { get; set; }
    public int ElectionId { get; set; } = 0;
    public int Candidate1 { get; set; } = 0;
    public int Candidate2 { get; set; } = 0;
    public int Candidate3 { get; set; } = 0;
}