namespace LINQ.Models;

public class Game
{
    public string? Name { get; init; }
    public string? Genre { get; init; }
    public int ReleaseYear { get; init; }
    public string? GameStudio { get; init; }
    public int Sales { get; init; }
    public List<Platform>? Platforms { get; init; }
}