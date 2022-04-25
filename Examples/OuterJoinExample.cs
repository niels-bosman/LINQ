namespace LINQ.Examples;

public class OuterJoinExample : Example
{
    protected override string Description => "TODO";

    protected override void RunQueryVariant()
    {
        var list =
            from game in Games
            join gameStudio in GameStudios on game.GameStudio equals gameStudio.Name into x
            from gameStudio in x.DefaultIfEmpty()
            select new
            {
                Game = game.Name,
                Studio = $"{game.GameStudio}: {gameStudio?.Headquarters ?? "Locatie niet bekend"}",
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
        var list = Games.GroupJoin(
            GameStudios,
            game => game.GameStudio,
            studio => studio.Name,
            (game, studio) => new { Game = game, Studio = studio }
        ).SelectMany(
            merge => merge.Studio.DefaultIfEmpty(),
            (game, studio) => new
            {
                Game = game.Game.Name,
                Studio = $"{game.Game.GameStudio}: {studio?.Headquarters ?? "Locatie niet bekend"}",
            }
        );
        
        foreach (var item in list)
        {
            Console.WriteLine(item.Game);
            Console.WriteLine($"Gemaakt door: {item?.Studio}");
            Console.WriteLine("");
        }
    }
}