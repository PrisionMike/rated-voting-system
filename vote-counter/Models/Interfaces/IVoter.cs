namespace vote_counter.Models.Interfaces;

public interface IVoter
{
    public int VoterId { get; set; }
    public string VoterName  { get; set; }
}