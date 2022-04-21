using LINQ.Models;

namespace LINQ.Examples;

public class MaxExample: WithoutQuerySyntaxExample
{
    protected override string Description => "We zoeken de game met de meeste sales.";

    protected override void RunWithMethod()
    {
        var most = Games.Max(game => game.Sales);
        
        DisplayData(most);
    }
    
    private static void DisplayData(int least)
    {
        Console.WriteLine($"De meeste sales: {least}");
    }
}