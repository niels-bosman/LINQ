namespace LINQ.Examples;

public class MaxExample: WithoutQuerySyntaxExample
{
    protected override string Description => "We zoeken de game met de meeste sales.";

    protected override void RunMethodVariant()
    {
        var most = Games.Max(game => game.Sales);
        
        Display(most);
    }
    
    private static void Display(int least)
    {
        Console.WriteLine($"De meeste sales: {least}");
    }
}