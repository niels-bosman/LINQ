using LINQ.Repositories;
using LINQ.Utils;

var games = new GameRepository().GetGames();
var gameStudios = new GameStudioRepository().GetGameStudios();

while (true)
{
    var example = View.AskExample();
    var type = View.AskType();

    example.Run(type, games, gameStudios);

    if (!View.AskToContinue()) break;
}

