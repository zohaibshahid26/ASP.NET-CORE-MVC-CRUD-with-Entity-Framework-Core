using Microsoft.EntityFrameworkCore;
using Lab3.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(optionsAction => optionsAction.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
       name: "user",
          pattern: "{controller=User}/{action=Index}/{id?}");
app.MapControllerRoute(
       name: "createuser",
          pattern: "{controller=User}/{action=Create}/{id?}");
app.MapControllerRoute(
       name: "updateuser",
                pattern: "{controller=User}/{action=Update}/{id?}");

app.MapControllerRoute(
       name: "product",
          pattern: "{controller=Product}/{action=Index}/{id?}");
app.MapControllerRoute(
       name: "subscription",
                pattern: "{controller=Subscription}/{action=Index}/{id?}");
app.MapControllerRoute(
          name: "clientSubscription",
          pattern: "{controller=ClientSubscription}/{action=Index}/{id?}");
app.Run();
