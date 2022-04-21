using LINQ.Models;

namespace LINQ.Examples;

public class AggregateExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We zoeken de game met de langste naam";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var name = games
            .Select(game => game.Name)
            .Aggregate((longest, next) => next?.Length > longest?.Length ? next : longest);
        
        DisplayData(name!);
    }
    
    private static void DisplayData(string name)
    {
        Console.WriteLine($"Langste naam: {name}");
    }
}