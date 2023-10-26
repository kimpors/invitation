using Invitation.Models;

namespace Invitation.Data;

public static class Seed
{
  public static void EnsurePopulated(IApplicationBuilder app)
  {
    using (var scope = app.ApplicationServices.CreateScope())
    {
      var ctx = scope.ServiceProvider.GetService<AppDbContext>();
      ctx.Database.EnsureCreated();

      if(!ctx.Invites.Any())
      {
        ctx.Invites.AddRange(
            new Invite 
            {
              Name = "John",
              LastName = "Builder",
              Phone = "+123456790",
              Email = "jogh@email.com",
              IsComeUp = true,
            },
            new Invite 
            {
              Name = "Jane",
              LastName = "House",
              Phone = "+123456790",
              Email = "jane@email.com",
              IsComeUp = false,
            },
            new Invite 
            {
              Name = "Jorg",
              LastName = "Jordan",
              Phone = "+123456790",
              Email = "j@email.com",
              IsComeUp = true,
            },
            new Invite 
            {
              Name = "Jonate",
              LastName = "Mary",
              Phone = "+123456790",
              Email = "mary@email.com",
              IsComeUp = false,
            },
            new Invite 
            {
              Name = "Jambo",
              LastName = "Jo",
              Phone = "+123456790",
              Email = "joo@email.com",
              IsComeUp = false,
            }
        );
        ctx.SaveChanges();
      }
    }
  }
}
