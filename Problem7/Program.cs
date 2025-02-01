

using Microsoft.EntityFrameworkCore;
using SweeftEFCodefirst.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SchoolDbcontext>(options =>
    options.UseSqlServer("Server=WINDOWS-NJ9LCT3;Database=SeeftEF;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"));


var app = builder.Build();


app.Run();

