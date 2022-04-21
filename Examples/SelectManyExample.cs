using LINQ.Models;

namespace LINQ.Examples;

public class SelectManyExample : Example
{
    protected override string Description => "We selecteren alle platforms van alle games.";
    
    protected override void RunWithQuery()
    {
        var list = 
            from game in Games
            from platform in game.Platforms
            select platform;
        
        DisplayData(list);
    }

    protected override void RunWithMethod()
    {
        var list = Games.SelectMany(game => game.Platforms);
        
        DisplayData(list);
    }

    private static void DisplayData(IEnumerable<Platform> platforms)
    {
        foreach (var platform in platforms)
        {
            var name = platform switch
            {
                Platform.Pc => "PC",
                Platform.Xbox360 => "Xbox 360",
                Platform.XboxOne => "Xbox One",
                Platform.Ps3 => "Playstation 3",
                Platform.Ps4 => "Playstation 4",
                Platform.Ps5 => "Playstation 5",
                Platform.NintendoSwitch => "Nintendo Switch",
            };
            
            Console.WriteLine(name);
        }
    }
}