using GameStore.Api.Data;
using GameStore.Api.Features.Games;
using GameStore.Api.Features.Genres;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//var connString = "Data SOurce=GameStore.db";

// builder.Services.AddDbContext<GameStoreContext>(options =>
//     options.UseSqlite(connString)
// );

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

// builder.Services.AddTransient<GameDataLogger>();
// builder.Services.AddSingleton<GameStoreData>();

var app = builder.Build();


app.MapGames();
app.MapGenres();

app.InitializeDb();

app.Run();







