using Microsoft.AspNetCore.Mvc;
using Invitation.Models;
using Invitation.Data;

namespace Invitation.Controllers;

public class HomeController : Controller
{
	private IInviteRepository _repo;

	public HomeController(IInviteRepository repo)
		=> _repo = repo;

    public IActionResult Index()
		=> View(_repo.Invites.Where(u => u.WillAttend));

	public IActionResult Form()
		=> View(new Invite() {
			Name = "",
			LastName = "",
			Email = "",
			Phone = ""});

	[HttpPost]
	public IActionResult Form(Invite invite)
	{
		if (ModelState.IsValid)
		{
			_repo.Add(invite);
			return View(nameof(Thanks), invite.WillAttend);
		}

		return View(invite);
	}

	public IActionResult Thanks(bool WillAttend)
		=> View(WillAttend);
}
