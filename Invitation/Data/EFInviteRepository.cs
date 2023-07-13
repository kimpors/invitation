using Invitation.Models;

namespace Invitation.Data;

public class EFInviteRepository : IInviteRepository
{
  private AppDbContext _ctx;

  public EFInviteRepository(AppDbContext ctx)
    => _ctx = ctx;

    public IQueryable<Invite> Invites 
      => _ctx.Invites;
}
