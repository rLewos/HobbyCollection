using Games.Infraestructure;
using Games.Repository;
using Games.Repository.Interfaces;
using Games.Service;
using Games.Service.Interfaces;
using Hobby.Repository;
using Hobby.Repository.Interfaces;
using Hobby.Service;
using Hobby.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("Default");
if (connectionString == null)
    throw new NullReferenceException("ConnectionString is null");

builder.Services.AddDbContext<HobbyContext>(opt => opt.UseNpgsql(connectionString));

builder.Services.AddTransient<IGameService, GameService>();
builder.Services.AddTransient<IGameRepository, GameRepository>();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddTransient<IDeveloperService, DeveloperService>();
builder.Services.AddTransient<IDeveloperRepository, DeveloperRepository>();

builder.Services.AddTransient<IPublisherService, PublisherService>();
builder.Services.AddTransient<IPublisherRepository, PublisherRepository>();

builder.Services.AddTransient<IPlataformService, PlataformService>();
builder.Services.AddTransient<IPlataformRepository, PlataformRepository>();

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
