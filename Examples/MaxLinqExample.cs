using LINQ.Models;

namespace LINQ.Examples;

public class MaxLinqExample: WithoutQuerySyntaxLinqExample
{
    protected override string Description => "We zoeken de game met de meeste sales.";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var least = games.Max(game => game.Sales);
        
        DisplayData(least);
    }
    
    private static void DisplayData(int least)
    {
        Console.WriteLine($"De meeste sales: {least}");
    }
}