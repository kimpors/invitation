using Invitation.Models;

namespace Invitation.Data;

public interface IInviteRepository
{
	IEnumerable<Invite> Invites { get; }
	public void Add(Invite invite);
}
