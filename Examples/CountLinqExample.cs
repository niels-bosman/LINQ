using LINQ.Models;

namespace LINQ.Examples;

public class CountLinqExample : WithoutQuerySyntaxLinqExample
{
    protected override string Description => "We tellen het aantal games waarvan de uitgever Riot Games is";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var amount = games.Count(game => game.GameStudio == "Riot Games");
        
        DisplayData(amount);
    }

    private static void DisplayData(int amount)
    {
        Console.WriteLine($"Het aantal games: {amount}");
    }
}