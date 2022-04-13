using LINQ.Models;

namespace LINQ.Examples;

public class OrderByLinqExample : LinqExample
{
    protected override string Description => "We sorteren de lijst van games op basis van de hoeveelheid sales, en daarna het releasejaar";

    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var list = games
            .OrderBy(game => game.Sales)
            .ThenBy(game => game.ReleaseYear)
            .ToList();
        
        DisplayData(list);
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = (
            from game in games
            orderby game.Sales, game.ReleaseYear
            select game
        ).ToList();

        DisplayData(list);
    }
}
