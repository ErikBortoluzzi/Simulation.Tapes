using Simulation.Tapes.ApplicationCore.Interfaces.Repository;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;
using Simulation.Tapes.Infrastructure;
using Simulation.Tapes.Infrastructure.Repository;
using Simulation.Tapes.Infrastructure.Service;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITapeService, TapeService>();
builder.Services.AddSingleton<ITapeRepository, TapeRepository>();

builder.Services.AddSingleton<ISectionService, SectionService>();
builder.Services.AddSingleton<ISectionRepository, SectionRepository>();



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
