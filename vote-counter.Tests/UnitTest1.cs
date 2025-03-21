using Microsoft.EntityFrameworkCore;
using Moq;
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

        using (var context = new AppDbContext(options))
        {
            var controller = new VoteCastingController(context);
            var vote = new Vote {Candidate1 = 1, ElectionId = 1};
        
            await controller.voteCasting(vote);
            var result = controller.GetElectionResult(1);
        
            Assert.Equal(1, result.CandidateId);
        }
    }
    
}
