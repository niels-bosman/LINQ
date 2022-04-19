using LINQ.Models;

namespace LINQ.Examples;

public class FirstLinqExample : WithoutQuerySyntaxLinqExample
{
    protected override string Description => "We selecteren de eerste game waarvan het genre 'Shooter' is";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var game = games.First(game => game.Genre == "Shooter");
        
        DisplayData(new List<Game> {game});
    }
}