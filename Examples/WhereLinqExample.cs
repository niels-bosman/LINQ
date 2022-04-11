using System.Collections;
using LINQ.Models;

namespace LINQ.Examples;

public class WhereLinqExample : ILinqExample
{
    public string Description => "We filteren de games die nieuwe zijn dan 2017";

    public List<Game> WithQuery(List<Game> games)
    {
        var result = 
            from game in games
            where game.ReleaseYear > 2017
            select game;

        return result.ToList();
    }

    public List<Game> WithMethod(List<Game> games)
    {
        return games
            .Where(game => game.ReleaseYear > 2017)
            .ToList();
    }
}