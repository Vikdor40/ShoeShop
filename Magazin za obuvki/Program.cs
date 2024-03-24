using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Magazin_za_obuvki.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Magazin_za_obuvkiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Magazin_za_obuvkiContext") ?? throw new InvalidOperationException("Connection string 'Magazin_za_obuvkiContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Run();
