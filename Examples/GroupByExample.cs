using LINQ.Models.Custom;

namespace LINQ.Examples;

public class GroupByExample : Example
{
    protected override string Description => "We groeperen alle games bij het genre.";

    protected override void RunQueryVariant()
    {
        var list = (
            from game in Games
            group game by game.Genre into merge
            select new GroupByModel
            {
                Games = merge.ToList(),
                Genre = merge.Key,
            }
        );
        
        Display(list);
    }

    protected override void RunMethodVariant()
    {
        var list = Games.GroupBy(
            game => game.Genre,
            (key, game) => new GroupByModel
            {
                Games = game.ToList(),
                Genre = key,
            }
        );
        
        Display(list);
    }
    
    private static void Display(IEnumerable<GroupByModel> list)
    {
        foreach (var listItem in list)
        {
            Console.WriteLine($"Genre: {listItem.Genre}");
            
            foreach (var game in listItem.Games)
            {
                Console.WriteLine($"  - {game.Name}");
            }
            
            Console.WriteLine("");
        }
    }
}