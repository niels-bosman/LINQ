namespace LINQ.Examples;

public class AverageExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We bekijken het gemiddelde releasejaar van alle games.";

    protected override void RunMethodVariant()
    {
        var average = Games.Average(game => game.ReleaseYear);
        
        Display(average);
    }
    
    private static void Display(double average)
    {
        Console.WriteLine($"Gemiddelde releasejaar: {average}");
    }
}