using LINQ.Models;

namespace LINQ.Examples;

public class SumLinqExample : LinqExample
{
    protected override string Description => "We berekenen de totale sales van alle games bij elkaar.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
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