using Invitation.Models;

namespace Invitation.Data;

public class InviteRepository : IInviteRepository
{
	private List<Invite> invites = new();
	private static readonly Random rn = new();

    public InviteRepository()
    {
		for (int i = 1; i <= 10; i++)
		{
			invites.Add(new Invite
			{
				Id = i,
				Name = GenerateName(),
				LastName = GenerateLastName(),
				Phone = GeneratePhone(),
				Email = GenerateEmail(),
				WillAttend = rn.Next(0, 2) == 1
			});
		}
    }

    public IEnumerable<Invite> Invites => invites;

    public void Add(Invite invite)
    {
		invites.Add(invite);
    }

	private static string GenerateName()
	{
		string[] names = { "John", "Jane", "Alice", "Bob", "Charlie", "Diana" };
        return names[rn.Next(names.Length)];
	}

	private static string GenerateLastName()
	{
		string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown" };
        return lastNames[rn.Next(lastNames.Length)];
	}

	private static string GeneratePhone()
	{
		return $"+1{ rn.NextInt64(1000000000, 9999999999)}"; 

	}

	private static string GenerateEmail()
	{
		string[] domains = { "example.com", "test.com", "demo.com" };
        return $"{GenerateName().ToLower()}.{GenerateLastName().ToLower()}@{domains[rn.Next(domains.Length)]}";
	}
}
