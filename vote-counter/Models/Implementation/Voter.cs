using vote_counter.Models.Interfaces;

namespace vote_counter.Models.Implementation;

// TODO: test todo.
public class Voter : IVoter
{
    public int VoterId { get; set; }
    public string VoterName  { get; set; }
}