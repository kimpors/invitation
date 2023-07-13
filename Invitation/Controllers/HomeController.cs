using Invitation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Invitation.Controllers;

public class HomeController : Controller
{
  public ViewResult Index()
    => View();

  public ViewResult Form()
    => View(new Invite());

  [HttpPost]
  public IActionResult Form(Invite invite)
  {
    if (ModelState.IsValid)
    {
      return View(nameof(Thanks), invite.IsComeUp);
    }

    return View(invite);
  }

  public ViewResult Thanks(bool isComeUp)
    => View(isComeUp);
}
