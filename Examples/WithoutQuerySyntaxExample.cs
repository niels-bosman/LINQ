using LINQ.Models;

namespace LINQ.Examples;

public abstract class WithoutQuerySyntaxExample : Example
{
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        Console.WriteLine("Dit voorbeeld heeft niet de mogelijkheid tot query syntax, gebruikt method syntax als alternatief.");
        
        RunWithMethod(games);
    }
}