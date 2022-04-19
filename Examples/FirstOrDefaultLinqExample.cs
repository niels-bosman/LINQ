using LINQ.Models;

namespace LINQ.Examples;

public class FirstOrDefaultLinqExample : LinqExample
{
    protected override string Description => "We selecteren de eerste game waar het genre 'Fighting' is";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var game = games
            .FirstOrDefault(game => game.Genre == "Fighting");
        
        DisplayData(new List<Game> {game});
    }
}