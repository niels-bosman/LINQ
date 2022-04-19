using LINQ.Models;

namespace LINQ.Examples;

public class SumLinqExample : LinqExample
{
    protected override string Description => "We berekenen de totale sales van alle games bij elkaar.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var least = (
            from game in games
            select game.Sales
        ).Sum();
        
        DisplayData(least);
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var least = games.Sum(game => game.Sales);
        
        DisplayData(least);
    }
    
    private static void DisplayData(int least)
    {
        Console.WriteLine($"Het aantal sales: {least}");
    }
}