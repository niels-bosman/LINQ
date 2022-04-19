using LINQ.Models;

namespace LINQ.Examples;

public class TakeLinqExample : LinqExample
{
    protected override string? Description => "We orderen de lijst op basis van sales en pakken de top 3";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = games
            .OrderByDescending(game => game.Sales)
            .Take(3);
        
        DisplayData(list);
    }
}