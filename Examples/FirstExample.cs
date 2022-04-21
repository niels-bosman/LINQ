using LINQ.Models;

namespace LINQ.Examples;

public class FirstExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We selecteren de eerste game waarvan het genre 'Shooter' is";

    protected override void RunWithMethod()
    {
        var game = Games.First(game => game.Genre == "Shooter");
        
        DisplayData(new List<Game> {game});
    }
}