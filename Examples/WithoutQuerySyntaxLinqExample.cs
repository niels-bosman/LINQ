using LINQ.Models;

namespace LINQ.Examples;

public abstract class WithoutQuerySyntaxLinqExample : LinqExample
{
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        Console.WriteLine("Dit voorbeeld heeft niet de mogelijkheid tot query syntax, gebruikt method syntax als alternatief.");
        RunWithMethod(games);
    }
}