namespace LINQ.Examples;

public class CountExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We tellen het aantal games waarvan de uitgever Riot Games is";

    protected override void RunMethodVariant()
    {
        var amount = Games.Count(game => game.GameStudio == "Riot Games");
        
        Display(amount);
    }

    private static void Display(int amount)
    {
        Console.WriteLine($"Het aantal games: {amount}");
    }
}