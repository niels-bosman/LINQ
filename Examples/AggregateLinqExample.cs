using LINQ.Models;

namespace LINQ.Examples;

public class AggregateLinqExample : LinqExample
{
    protected override string Description => "We zoeken de game met de langste naam";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

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