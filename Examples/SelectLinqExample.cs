using LINQ.Models;

namespace LINQ.Examples;

public class SelectLinqExample : LinqExample
{
    protected override string Description => "We halen selecteren alle sales en delen ze door 100.";

    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var list = games
            .Select(game => game.Sales / 100)
            .ToList();
        
        DisplayData(list);
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = (
            from game in games
            select game.Sales / 100
        ).ToList();
        
        DisplayData(list);
    }

    private static void DisplayData(IEnumerable<int> sales)
    {
        foreach (var sale in sales)
        {
            Console.WriteLine(sale);
        }
    }
}