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
        var mockdbContext = new Mock<AppDbContext>();
        var mockDbSet = new Mock<DbSet<Vote>>();
        
        mockdbContext.Setup(db => db.Votes).Returns(mockDbSet.Object);
        
        var controller = new VoteCastingController(mockdbContext.Object);
        var vote = new Vote {Candidate1 = 1, ElectionId = 1};
        
        await controller.voteCasting(vote);
        var result = await controller.GetElectionResult(1);
        
        Assert.Equal(result, 1);
        
    }
    
}
