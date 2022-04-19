using LINQ.Models;

namespace LINQ.Examples;

public class MaxLinqExample: LinqExample
{
    protected override string Description => "We zoeken de game met de meeste sales.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
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