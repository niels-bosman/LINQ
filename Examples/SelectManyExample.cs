using LINQ.Models;

namespace LINQ.Examples;

public class SelectManyExample : Example
{
    protected override string Description => "We selecteren alle platforms van alle games.";
    
    protected override void RunQueryVariant()
    {
        var list = 
            from game in Games
            from platform in game.Platforms!
            select platform;
        
        Display(list);
    }

    protected override void RunMethodVariant()
    {
        var list = Games.SelectMany(game => game.Platforms!);
        
        Display(list);
    }

    private static void Display(IEnumerable<Platform> platforms)
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
                _ => "",
            };
            
            Console.WriteLine(name);
        }
    }
}