namespace LINQ.Examples;

public class TakeExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We orderen de lijst op basis van sales en pakken de top 3";

    protected override void RunMethodVariant()
    {
        var list = Games
            .OrderByDescending(game => game.Sales)
            .Take(3);
        
        Display(list);
    }
}