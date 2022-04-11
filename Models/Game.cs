namespace LINQ.Models;

public class Game
{
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public int ReleaseYear { get; set; }
    public string? GameStudio { get; set; }
    public int Sales { get; set; }
    public List<Platform>? Platforms { get; set; }

    public void ToTable()
    {
        Console.Write($"|{Name,5}|{Genre,5}|{ReleaseYear,5}|{Sales,5}\n");
    }
}