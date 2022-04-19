using LINQ.Models;

namespace LINQ.Examples;

public class CountLinqExample : LinqExample
{
    protected override string Description => "We tellen het aantal games waarvan de uitgever Riot Games is";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var amount = games.Count(game => game.GameStudio == "Riot Games");
        
        DisplayData(amount);
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var amount = (
            from game in games
            where game.GameStudio == "Riot Games"
            select game
        ).Count();
        
        DisplayData(amount);
    }

    private static void DisplayData(int amount)
    {
        Console.WriteLine($"Het aantal games: {amount}");
    }
}