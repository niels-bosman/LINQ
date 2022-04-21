using LINQ.Models;

namespace LINQ.Examples;

public class TakeExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We orderen de lijst op basis van sales en pakken de top 3";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = games
            .OrderByDescending(game => game.Sales)
            .Take(3);
        
        DisplayData(list);
    }
}