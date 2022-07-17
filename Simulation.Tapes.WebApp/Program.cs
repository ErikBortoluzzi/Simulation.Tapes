using Simulation.Tapes.ApplicationCore.Interfaces.Repository;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;
using Simulation.Tapes.Infrastructure;
using Simulation.Tapes.Infrastructure.Repository;
using Simulation.Tapes.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ITapeService, TapeService>();
builder.Services.AddSingleton<ITapeRepository, TapeRepository>();

builder.Services.AddSingleton<ISectionService, SectionService>();
builder.Services.AddSingleton<ISectionRepository, SectionRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
