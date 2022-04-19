using LINQ.Models;

namespace LINQ.Examples;

public class DistinctLinqExample : WithoutQuerySyntaxLinqExample
{
    protected override string Description => "We tonen alle unieke Game studios";

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