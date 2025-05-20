using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vote_counter.Controllers;
using vote_counter.Data;
using vote_counter.Models.Implementation;
using vote_counter.Models.Interfaces;
using vote_counter.Repository.Implementation;
using vote_counter.Repository.Interfaces;
using vote_counter.Services.Implementation;
using vote_counter.Services.Interface;

namespace vote_counter.Tests;

public class VoteCastingTests
{
    [Fact]
    public async Task one_vote_election()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "one_vote_election")
            .Options;

        await using var context = new AppDbContext(options);

        // Add candidate
        ICandidate candidate = new Candidate { CandidateId = 1, FirstName = "PK" };
        context.Candidates.Add((Candidate)candidate);
        await context.SaveChangesAsync();

        // Set up the interface-based chain
        IBallotRepository repo = new BallotRepository(context);
        IRatingCalculationService service = new RatingCalculationService(repo);
        var controller = new VoteCastingController(service); // this still takes IBallotService

        // Create vote
        IBallot ballot = new Ballot { Candidate1 = 1, ElectionId = 1 };

        // Act
        await controller.CastBallot((Ballot)ballot); // controller expects concrete Ballot
        var result = controller.GetElectionResult(1);

        // Assert
        var okResult = Assert.IsType<ActionResult<ICandidate>>(result);
        var objectResult = Assert.IsType<OkObjectResult>(okResult.Result);
        var winner = Assert.IsAssignableFrom<ICandidate>(objectResult.Value);
        Assert.Equal(1, winner.CandidateId);
    }
}