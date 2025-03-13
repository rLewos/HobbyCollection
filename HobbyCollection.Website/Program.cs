using Games.Infraestructure;
using HobbyCollection.Website;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Add services to the container.

string? connectionString = builder.Configuration.GetConnectionString("Default");
if (connectionString == null)
    throw new NullReferenceException("ConnectionString is null");

builder.Services.AddDbContext<HobbyContext>(opt => opt.UseNpgsql(connectionString));

// Is this the best way to do this 'class mapping'?
InjectionDependeceMapping idMapping = new (builder.Services) ;
idMapping.Init();

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

app.MapControllerRoute(name: "default",   pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
