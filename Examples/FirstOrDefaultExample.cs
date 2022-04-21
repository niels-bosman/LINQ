using LINQ.Models;

namespace LINQ.Examples;

public class FirstOrDefaultExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We selecteren de eerste game waar het genre 'Fighting' is";

    protected override void RunWithMethod()
    {
        var game = Games.FirstOrDefault(game => game.Genre == "Fighting");

        DisplayData(new List<Game?> {game});
    }
}