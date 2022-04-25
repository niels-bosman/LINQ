namespace LINQ.Examples;

public class JoinExample : Example
{
    protected override string Description => "We joinen de games met de game studio en voegen de locatie van de headquarters toe achter de naam van de studio.";

    protected override void RunQueryVariant()
    {
        var list =
            from game in Games
            join gameStudio in GameStudios on game.GameStudio equals gameStudio?.Name
            select new
            {
                Game = game.Name,
                Studio = $"{game.GameStudio} - {gameStudio.Headquarters}",
            };

        foreach (var item in list)
        {
            Console.WriteLine(item.Game);
            Console.WriteLine($"Gemaakt door: {item.Studio}");
            Console.WriteLine("");
        }
    }

    protected override void RunMethodVariant()
    {
        var list = Games.Join(
            GameStudios,
            game => game.GameStudio,
            gameStudio => gameStudio.Name,
            (game, gameStudio) => new
            {
                Game = game.Name,
                Studio = $"{gameStudio.Name} - {gameStudio.Headquarters}",
            }
        );
        
        foreach (var item in list)
        {
            Console.WriteLine(item.Game);
            Console.WriteLine($"Gemaakt door: {item.Studio}");
            Console.WriteLine("");
        }
    }
}