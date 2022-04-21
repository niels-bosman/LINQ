namespace LINQ.Examples;

public class DistinctExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We tonen alle unieke Game studios";

    protected override void RunMethodVariant()
    {
        var list = Games
            .Select(game => game.GameStudio)
            .Distinct();
        
        Display(list);
    }
    
    private static void Display(IEnumerable<string?> studios)
    {
        foreach (var studio in studios)
        {
            Console.WriteLine($"- {studio}");
        }
    }
}