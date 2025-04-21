using vote_counter.Models.Interfaces;

namespace vote_counter.Models.Implementation;

public class Election : IElection
{
    public int ElectionId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}