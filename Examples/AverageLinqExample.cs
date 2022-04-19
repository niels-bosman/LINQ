using LINQ.Models;

namespace LINQ.Examples;

public class AverageLinqExample : LinqExample
{
    protected override string Description => "We bekijken het gemiddelde releasejaar van alle games.";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        var average = (
            from game in games
            select game.ReleaseYear
        ).Average();
        
        DisplayData(average);
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var average = games.Average(game => game.ReleaseYear);
        
        DisplayData(average);
    }
    
    private static void DisplayData(double average)
    {
        Console.WriteLine($"Gemiddelde releasejaar: {average}");
    }
}