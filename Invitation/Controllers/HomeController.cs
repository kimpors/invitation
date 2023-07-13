using Microsoft.AspNetCore.Mvc;

namespace Invitation.Controllers;

public class HomeController : Controller
{
  public ViewResult Index()
    => View("Index", "Hello there");
}
