namespace LINQ.Models;

public class Game
{
    private string? Name { get; set; }
    private string? Genre { get; set; }
    private int ReleaseYear { get; set; }
    private string? GameStudio { get; set; }
    private int Downloads { get; set; }
    private Platform[]? Platforms { get; set; }
}