using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestionApp.Data;
using GestionApp.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<GestionAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GestionAppContext") ?? throw new InvalidOperationException("Connection string 'GestionAppContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedAlumno.Initialize(services);
    SeedProfesor.Initialize(services);
    SeedMateria.Initialize(services);
    SeedCalificacion.Initialize(services);
    SeedAsignada.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
