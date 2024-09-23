using System.ComponentModel.DataAnnotations;

namespace Invitation.Models;

public class Invite
{
  public int Id { get; set; }

  [Required(ErrorMessage = "Please, enter the name")]
  public required string Name { get; set; }

  [Required(ErrorMessage = "Please, enter the lastname")]
  public required string LastName { get; set; }

  [Required(ErrorMessage = "Please, enter the phone")]
  public required string Phone { get; set; }

  [Required(ErrorMessage = "Please, enter the email")]
  public required string Email { get; set; }

  public bool WillAttend { get; set; }
}
