using LINQ.Models;

namespace LINQ.Examples;

public class MaxLinqExample: LinqExample
{
    protected override string Description => "We zoeken de game met de meeste sales.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var least = (
            from game in games
            select game.Sales
        ).Max();
        
        DisplayData(least);
    }

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