using System.ComponentModel.DataAnnotations;

namespace Invitation.Models;

public class Invite
{
  [Required(ErrorMessage = "Please, enter the name")]
  public string Name { get; set; }

  [Required(ErrorMessage = "Please, enter the lastname")]
  public string LastName { get; set; }

  [Required(ErrorMessage = "Please, enter the phone")]
  public string Phone { get; set; }

  [Required(ErrorMessage = "Please, enter the email")]
  public string Email { get; set; }

  public bool IsComeUp { get; set; }
}
