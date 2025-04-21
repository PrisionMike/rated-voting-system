namespace vote_counter.Models.Interfaces;

public interface IElection
{
    int ElectionId { get; set; }
    DateTime StartTime { get; set; }
    DateTime EndTime { get; set; }
}