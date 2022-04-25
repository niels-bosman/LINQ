using LINQ.Models;

namespace LINQ.Utils;

public static class EnumerableExtension
{
    public static IEnumerable<Game> WhereReleasedThisYear(this IEnumerable<Game> games)
    {
        foreach (var game in games)
        {
            if (game.ReleaseYear == DateTime.Now.Year)
            {
                yield return game;
            }
        }
    }
}