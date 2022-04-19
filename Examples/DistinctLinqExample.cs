using LINQ.Models;

namespace LINQ.Examples;

public class DistinctLinqExample : LinqExample
{
    protected override string? Description => "We tonen alle unieke Game studios";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var list = games
            .Select(game => game.GameStudio)
            .Distinct();
        
        DisplayData(list);
    }
    
    private static void DisplayData(IEnumerable<string?> studios)
    {
        foreach (var studio in studios)
        {
            Console.WriteLine($"- {studio}");
        }
    }
}