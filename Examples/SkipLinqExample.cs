using LINQ.Models;

namespace LINQ.Examples;

public class SkipLinqExample : LinqExample
{
    protected override string Description => "We slaan de eerste twee games over in de lijst.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = games.Skip(2);
        
        DisplayData(list);
    }
}