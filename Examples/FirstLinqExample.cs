using LINQ.Models;

namespace LINQ.Examples;

public class FirstLinqExample : LinqExample
{
    protected override string Description => "We selecteren de eerste game waarvan het genre 'Shooter' is";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var game = games.First(game => game.Genre == "Shooter");
        
        DisplayData(new List<Game> {game});
    }
}