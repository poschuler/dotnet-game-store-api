using System;
using GameStore.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
    : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres  => Set<Genre>();

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Genre>().HasData(
    //         new Genre { Id = Guid.NewGuid(), Name = "Action" },
    //         new Genre { Id = Guid.NewGuid(), Name = "Adventure" },
    //         new Genre { Id = Guid.NewGuid(), Name = "RPG" },
    //         new Genre { Id = Guid.NewGuid(), Name = "Simulation" },
    //         new Genre { Id = Guid.NewGuid(), Name = "Strategy" }
    //     );

    //     modelBuilder.Entity<Game>().HasData(
    //         new Game
    //         {
    //             Id = Guid.NewGuid(),
    //             Name = "Halo",
    //             GenreId = Guid.NewGuid(),
    //             Price = 59.99m,
    //             ReleaseDate = new DateOnly(2020, 11, 15),
    //             Description = "A first-person shooter game"
    //         },
    //         new Game
    //         {
    //             Id = Guid.NewGuid(),
    //             Name = "The Sims",
    //             GenreId = Guid.NewGuid(),
    //             Price = 39.99m,
    //             ReleaseDate = new DateOnly(2020, 12, 15),
    //             Description = "A life simulation game"
    //         },
    //         new Game
    //         {
    //             Id = Guid.NewGuid(),
    //             Name = "Civilization VI",
    //             GenreId = Guid.NewGuid(),
    //             Price = 29.99m,
    //             ReleaseDate = new DateOnly(2020, 10, 15),
    //             Description = "A turn-based strategy game"
    //         }
    //     );
    // }
}
