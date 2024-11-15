using System;
using GameStore.Api.Data;
using GameStore.Api.Features.Games.Constants;

namespace GameStore.Api.Features.Games.GetGame;

public static class GetGameEndpoint
{
    public static void MapGetGame(
        this IEndpointRouteBuilder app)
    {
        app.MapGet("/{id}", (
            Guid id,
            GameStoreContext dbContext) =>
        {
            var game = dbContext.Games.Find(id);

            if (game is null)
            {
                return Results.NotFound();
            }
            
            var gameDetails = new GameDetailsDto(game.Id, game.Name, game.GenreId, game.Price, game.ReleaseDate);
            return Results.Ok(gameDetails);
        })
        .WithName(EndpointsNames.GetGame);
    }

}
