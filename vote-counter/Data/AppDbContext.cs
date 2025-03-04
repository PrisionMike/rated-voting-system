using Microsoft.EntityFrameworkCore;
using vote_counter.Models;

namespace vote_counter.Data;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Candidate> Candidates { get; set; } = null!;
    public DbSet<Vote> Votes { get; set; } = null!;
    public DbSet<Voter> Voters { get; set; } = null!;
    public DbSet<Election> Elections { get; set; } = null!;
}