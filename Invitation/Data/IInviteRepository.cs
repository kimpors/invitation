using Invitation.Models;

namespace Invitation.Data;

public interface IInviteRepository
{
  public IQueryable<Invite> Invites { get; }

  public void SaveInvite(Invite invite);
}
