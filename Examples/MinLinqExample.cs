using LINQ.Models;

namespace LINQ.Examples;

public class MinLinqExample : LinqExample
{
    protected override string Description => "We zoeken de game met de minste sales.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var least = (
            from game in games
            select game.Sales
        ).Min();
        
        DisplayData(least);
    }

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