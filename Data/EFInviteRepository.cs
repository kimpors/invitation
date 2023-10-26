using Invitation.Models;

namespace Invitation.Data;

public class EFInviteRepository : IInviteRepository
{
  private AppDbContext _ctx;

  public EFInviteRepository(AppDbContext ctx)
    => _ctx = ctx;

    public IQueryable<Invite> Invites 
      => _ctx.Invites;

    public void SaveInvite(Invite invite)
    {
      if (invite.Id == 0)
      {
        _ctx.Invites.Add(invite);
      }
      else
      {
        Invite entry = _ctx.Invites
          .FirstOrDefault(u => u.Id == invite.Id);

        if (entry is null)
        {
          entry.Name = invite.Name;
          entry.LastName = invite.LastName;
          entry.Phone = invite.Phone;
          entry.Email = invite.Email;
        }
      }

      _ctx.SaveChanges();
    }
}
