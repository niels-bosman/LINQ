using LINQ.Models;

namespace LINQ.Examples;

public class SumLinqExample : WithoutQuerySyntaxLinqExample
{
    protected override string Description => "We berekenen de totale sales van alle games bij elkaar.";

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