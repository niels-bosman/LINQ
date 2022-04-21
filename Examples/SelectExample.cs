namespace LINQ.Examples;

public class SelectExample : Example
{
    protected override string Description => "We halen selecteren alle sales en delen ze door 100.";

    protected override void RunQueryVariant()
    {
        var list =
            from game in Games
            select game.Sales / 100;

        Display(list);
    }

    protected override void RunMethodVariant()
    {
        var list = Games
            .Select(game => game.Sales / 100)
            .ToList();
        
        Display(list);
    }

    private static void Display(IEnumerable<int> sales)
    {
        foreach (var sale in sales)
        {
            Console.WriteLine(sale.ToString("N0"));
        }
    }
}