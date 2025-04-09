using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vote_counter.Controllers;
using vote_counter.Data;
using vote_counter.Models;

namespace vote_counter.Tests;

public class UnitTest1
{
    [Fact]
    public async Task one_vote_election()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "one_vote_election")
            .Options;

        await using var context = new AppDbContext(options);
        var candidate = new Candidate { CandidateId = 1, FirstName = "John" };
        context.Candidates.Add(candidate);
            
        await context.SaveChangesAsync();
        var controller = new VoteCastingController(context);
        var vote = new Vote {Candidate1 = 1, ElectionId = 1};
        
        await controller.voteCasting(vote);
        var actionResult = controller.GetElectionResult(1);
        
        var okResult = Assert.IsType<ActionResult<Candidate>>(actionResult);
        var objectResult = Assert.IsType<OkObjectResult>(okResult.Result);

        var winner = Assert.IsType<Candidate>(objectResult.Value);
        Assert.Equal(1, winner.CandidateId);
    }
    
}
