using LINQ.Models;

namespace LINQ.Examples;

public class OrderByLinqExample : ILinqExample
{
    public string? Description => "We orderen de lijst van games op basis van de hoeveelheid sales";
    
    public List<Game> WithQuery(List<Game> games)
    {
        return games
            .OrderBy(game => game.Sales)
            .ToList();
    }

    public List<Game> WithMethod(List<Game> games)
    {
        var result =
            from game in games
            orderby game.Sales
            select game;

        return result.ToList();
    }
}