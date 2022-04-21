using LINQ.Models;

namespace LINQ.Examples;

public class AverageExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We bekijken het gemiddelde releasejaar van alle games.";

    protected override void RunWithMethod()
    {
        var average = Games.Average(game => game.ReleaseYear);
        
        DisplayData(average);
    }
    
    private static void DisplayData(double average)
    {
        Console.WriteLine($"Gemiddelde releasejaar: {average}");
    }
}