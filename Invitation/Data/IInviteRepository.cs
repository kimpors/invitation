using Invitation.Models;

namespace Invitation.Data;

interface IInviteRepository
{
  public IQueryable<Invite> Invites { get; }
}
