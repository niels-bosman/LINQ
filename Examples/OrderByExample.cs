namespace LINQ.Examples;

public class OrderByExample : Example
{
    protected override string Description => "We sorteren de lijst van games op basis van de hoeveelheid sales, en daarna het releasejaar";

    protected override void RunWithQuery()
    {
        var list =
            from game in Games
            orderby game.Sales, game.ReleaseYear
            select game;
        
        DisplayData(list);
    }

    protected override void RunWithMethod()
    {
        var list = Games
            .OrderBy(game => game.Sales)
            .ThenBy(game => game.ReleaseYear)
            .ToList();
        
        DisplayData(list);
    }
}
