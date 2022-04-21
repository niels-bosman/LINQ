namespace LINQ.Examples;

public class AggregateExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We zoeken de game met de langste naam";

    protected override void RunMethodVariant()
    {
        var name = Games
            .Select(game => game.Name)
            .Aggregate((longest, next) => next?.Length > longest?.Length ? next : longest);
        
        Display(name!);
    }
    
    private static void Display(string name)
    {
        Console.WriteLine($"Langste naam: {name}");
    }
}