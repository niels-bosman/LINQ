using LINQ.Repositories;
using LINQ.Utils;

var games = new GameRepository().GetGames();

while (true)
{
    var example = View.AskExample();
    var type = View.AskType();

    example.Run(type, games);

    if (!View.AskToContinue()) break;
}

