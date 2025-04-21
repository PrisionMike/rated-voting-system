using Microsoft.EntityFrameworkCore;
using vote_counter.Models;
using vote_counter.Models.Implementation;

namespace vote_counter.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Candidate> Candidates { get; set; } = null!;
    public DbSet<Election> Elections { get; set; } = null!;
    public DbSet<Ballot> Ballots { get; set; } = null!;
}