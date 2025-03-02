namespace vote_counter.Models;

public class Election
{
    public int ElectionId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}