using LINQ.Models;

namespace LINQ.Examples;

public class SkipExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We slaan de eerste twee games over in de lijst.";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = games.Skip(2);
        
        DisplayData(list);
    }
}