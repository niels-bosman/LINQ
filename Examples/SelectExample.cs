namespace LINQ.Examples;

public class SelectExample : Example
{
    protected override string Description => "We halen selecteren alle sales en delen ze door 100.";

    protected override void RunWithQuery()
    {
        var list =
            from game in Games
            select game.Sales / 100;

        DisplayData(list);
    }

    protected override void RunWithMethod()
    {
        var list = Games
            .Select(game => game.Sales / 100)
            .ToList();
        
        DisplayData(list);
    }

    private static void DisplayData(IEnumerable<int> sales)
    {
        foreach (var sale in sales)
        {
            Console.WriteLine(sale.ToString("N0"));
        }
    }
}