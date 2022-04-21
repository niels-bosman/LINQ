namespace LINQ.Examples;

public class SumExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We berekenen de totale sales van alle games bij elkaar.";

    protected override void RunMethodVariant()
    {
        var least = Games.Sum(game => game.Sales);
        
        Display(least);
    }
    
    private static void Display(int least)
    {
        Console.WriteLine($"Het aantal sales: {least}");
    }
}