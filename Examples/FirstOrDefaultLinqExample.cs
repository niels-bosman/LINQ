using LINQ.Models;

namespace LINQ.Examples;

public class FirstOrDefaultLinqExample : WithoutQuerySyntaxLinqExample
{
    protected override string Description => "We selecteren de eerste game waar het genre 'Fighting' is";

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var game = games
            .FirstOrDefault(game => game.Genre == "Fighting");
        
        DisplayData(new List<Game> {game});
    }
}