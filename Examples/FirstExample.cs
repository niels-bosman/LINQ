using LINQ.Models;

namespace LINQ.Examples;

public class FirstExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We selecteren de eerste game waarvan het genre 'Shooter' is";

    protected override void RunMethodVariant()
    {
        var game = Games.First(game => game.Genre == "Shooter");
        
        Display(new List<Game> {game});
    }
}