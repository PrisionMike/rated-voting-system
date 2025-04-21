namespace vote_counter.Models.Interfaces;

public interface IBallot
{
    int Id { get; set; }
    int ElectionId { get; set; }
    int Candidate1 { get; set; }
    int Candidate2 { get; set; }
    int Candidate3 { get; set; }
}