using LINQ.Models;

namespace LINQ.Examples;

public class WhereExample : Example
{
    protected override string Description => "We filteren de games die nieuwe zijn dan 2017";

    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var list =
            from game in games
            where game.ReleaseYear > 2017
            select game;

        DisplayData(list);
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = games
            .Where(game => game.ReleaseYear > 2017)
            .ToList();

        DisplayData(list);
    }
}