using Invitation.Models;
using Microsoft.EntityFrameworkCore;

namespace Invitation.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

  public DbSet<Invite> Invites  { get; set; }
}
