using LINQ.Models;

namespace LINQ.Examples;

public class JoinExample : Example
{
    protected override string Description => "We joinen de games met de game studio en voegen de locatie van de headquarters toe achter de naam van de studio.";

    protected override void RunQueryVariant()
    {
        var list = (
            from game in Games
            join gameStudio in GameStudios on game.GameStudio equals gameStudio.Name
            select new Game
            {
                Name = game.Name,
                Genre = game.Genre,
                Platforms = game.Platforms,
                Sales = game.Sales,
                GameStudio = $"{gameStudio.Name} - {gameStudio.Headquarters}",
                ReleaseYear = game.ReleaseYear,
            }
        );
        
        Display(list);
    }

    protected override void RunMethodVariant()
    {
        var list = Games.Join(
            GameStudios,
            game => game.GameStudio,
            gameStudio => gameStudio.Name,
            (game, gameStudio) => new Game
            {
                Name = game.Name,
                Genre = game.Genre,
                Platforms = game.Platforms,
                Sales = game.Sales,
                GameStudio = $"{gameStudio.Name} - {gameStudio.Headquarters}",
                ReleaseYear = game.ReleaseYear,
            }
        );
        
        Display(list);
    }
}