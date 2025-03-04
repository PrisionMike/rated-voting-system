using Microsoft.AspNetCore.Mvc;
using vote_counter.Data;
using vote_counter.Models;

namespace vote_counter.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VoteCastingController : ControllerBase
{
    private readonly AppDbContext _context;

    public VoteCastingController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<bool>> voteCasting(Vote vote)
    {
        _context.Votes.Add(vote);
        await _context.SaveChangesAsync();
        return true;
    }
}