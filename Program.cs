using Invitation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string invite = builder.Configuration.GetConnectionString("Invite") ?? "Error";

builder.Services.AddDbContext<AppDbContext>(options =>
{
  options.UseMySql(invite, ServerVersion.AutoDetect(invite));
});
builder.Services.AddTransient<IInviteRepository, EFInviteRepository>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

Seed.EnsurePopulated(app);
app.Run();
