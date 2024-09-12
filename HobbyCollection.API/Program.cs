using Games.Infraestructure;
using Hobby.Infraestructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string? connectionString = builder.Configuration.GetConnectionString("Default");
if (connectionString == null)
	throw new NullReferenceException("ConnectionString is null");

builder.Services.AddDbContext<HobbyContext>(opt => opt.UseNpgsql(connectionString));

// Is this the best way to do this 'class mapping'?
InjectionDependeceMapping idMapping = new(builder.Services);
idMapping.Init();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();