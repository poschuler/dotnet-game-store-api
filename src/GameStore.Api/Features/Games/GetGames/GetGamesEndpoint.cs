using System;
using GameStore.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Features.Games.GetGames;

public static class GetGamesEndpoint
{
    public static void MapGetGames(
        this IEndpointRouteBuilder app)
    {
        app.MapGet("/", (GameStoreContext dbContext) => 
            dbContext.Games
                .Include(g => g.Genre)
                .Select(g => new GameSummaryDto(
                        g.Id, 
                        g.Name, 
                        g.Genre!.Name, 
                        g.Price, 
                        g.ReleaseDate
                        ))
                        .AsNoTracking()
                        );
    }
}
