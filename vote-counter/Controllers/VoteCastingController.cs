using Microsoft.AspNetCore.Mvc;
using vote_counter.Data;
using vote_counter.Models;

namespace vote_counter.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VoteCastingController(AppDbContext context) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<bool>> voteCasting(Vote vote)
    {
        context.Votes.Add(vote);
        await context.SaveChangesAsync();
        return Ok(true);
    }

    [HttpGet]
    public ActionResult<Candidate> GetElectionResult(int electionId)
    {
        var results = new List<int>();
        var allVotes = context.Votes.Select(x => x).Where(x => x.ElectionId == electionId).ToList();
        results.Add(allVotes.Sum(x => x.Candidate1));
        results.Add(allVotes.Sum(x => x.Candidate2));
        results.Add(allVotes.Sum(x => x.Candidate3));
        results.Add(allVotes.Sum(x => x.Candidate4));
        
        var winningCandidateId = results.IndexOf(results.Max()) + 1;

        var winner = context.Candidates
            .Select(x => x).SingleOrDefault(x => x.CandidateId == winningCandidateId);
        // ?? throw new InvalidOperationException($"No candidate found with ID {winningCandidateId}");
        
        return winner == null ? NotFound($"No candidate found with ID {winningCandidateId}") : Ok(winner);
    }
}