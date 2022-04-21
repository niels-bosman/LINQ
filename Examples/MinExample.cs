namespace LINQ.Examples;

public class MinExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We zoeken de game met de minste sales.";

    protected override void RunMethodVariant()
    {
        var least = Games.Min(game => game.Sales);
        
        Display(least);
    }
    
    private static void Display(int least)
    {
        Console.WriteLine($"De minste sales: {least}");
    }
}