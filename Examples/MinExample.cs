using LINQ.Models;

namespace LINQ.Examples;

public class MinExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We zoeken de game met de minste sales.";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var least = games.Min(game => game.Sales);
        
        DisplayData(least);
    }
    
    private static void DisplayData(int least)
    {
        Console.WriteLine($"De minste sales: {least}");
    }
}