using Microsoft.AspNetCore.Builder;
using GameLibraryApi.Models;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();


List<Game> games =
[
    new() { Id = 1, Title = "The Legend of Zelda: Breath of the Wild", Edition = "Standard", Platform = "Nintendo Switch", IsOwnedPhysical = true, IsOwnedDigital = false },
    new() { Id = 2, Title = "God of War", Edition = "Deluxe", Platform = "PlayStation 4", IsOwnedPhysical = false, IsOwnedDigital = true },
    new() { Id = 3, Title = "Halo Infinite", Edition = "Standard", Platform = "Xbox Series X", IsOwnedPhysical = true, IsOwnedDigital = true },
    new() { Id = 4, Title = "Cyberpunk 2077", Edition = "Collector's Edition", Platform = "PC", IsOwnedPhysical = false, IsOwnedDigital = true },
    new() { Id = 5, Title = "Super Mario Odyssey", Edition = "Standard", Platform = "Nintendo Switch", IsOwnedPhysical = true, IsOwnedDigital = false }
];

app.MapGet("/games", () =>
{

    return Results.Ok(games);

})
.WithName("GetGames");

app.Run();
