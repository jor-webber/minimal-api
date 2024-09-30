using SanteMinimalWebApi.Models;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/patient", (Patient patient) =>
{
    if (patient.Id != null)
    {
        Console.WriteLine(JsonSerializer.Serialize(patient));
        return Results.Ok();
    }
    return Results.BadRequest();
});

app.Run();