using LINQ.Models;

namespace LINQ.Examples;

public class FirstOrDefaultExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We selecteren de eerste game waar het genre 'Fighting' is";

    protected override void RunMethodVariant()
    {
        var game = Games.FirstOrDefault(game => game.Genre == "Fighting");

        Display(new List<Game?> {game});
    }
}