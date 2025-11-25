using DemoDockerComposeAPI_DB.Data;
using DemoDockerComposeAPI_DB.Data.Interfaces;
using DemoDockerComposeAPI_DB.Data.Repos;
using DemoDockerComposeAPI_DB.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var connectionString = @"Data Source=demodb;Initial Catalog=StudentDB;User ID=sa;Password=Test1234!;TrustServerCertificate=True;";

builder.Services.AddDbContext<StudentContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

var app = builder.Build();

app.MapStudentEndpoints();

app.Run();
