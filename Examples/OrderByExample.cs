namespace LINQ.Examples;

public class OrderByExample : Example
{
    protected override string Description => "We sorteren de lijst van games op basis van de hoeveelheid sales, en daarna het releasejaar. Beide aflopend.";

    protected override void RunQueryVariant()
    {
        var list =
            from game in Games
            orderby game.Sales descending, game.ReleaseYear descending
            select game;
        
        Display(list);
    }

    protected override void RunMethodVariant()
    {
        var list = Games
            .OrderByDescending(game => game.Sales)
            .ThenByDescending(game => game.ReleaseYear);
        
        Display(list);
    }
}
