using Invitation.Models;
using Invitation.Data;

using Microsoft.AspNetCore.Mvc;

namespace Invitation.Controllers;

public class HomeController : Controller
{
  private IInviteRepository _repo;

  public HomeController(IInviteRepository repo)
    => _repo = repo;

  public ViewResult Index()
    => View(_repo.Invites.Where(u => u.IsComeUp));

  public ViewResult Form()
    => View(new Invite(){
        Name = "",
        LastName = "",
        Email = "",
        Phone = ""});

  [HttpPost]
  public IActionResult Form(Invite invite)
  {
    if (ModelState.IsValid)
    {
      _repo.SaveInvite(invite);
      return View(nameof(Thanks), invite.IsComeUp);
    }

    return View(invite);
  }

  public ViewResult Thanks(bool isComeUp)
    => View(isComeUp);
}
