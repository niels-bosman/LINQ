using LINQ.Models;

namespace LINQ.Utils;

public static class GameTableGenerator
{
    private const int TableWidth = 200;

    public static void Generate(IEnumerable<Game?> games)
    {
        PrintLine();
        PrintRow("Naam", "Genre", "Releasejaar", "Studio", "Sales");
        PrintLine();
        foreach (var game in games)
        {
            if (game != null)
            {
                PrintRow(game.Name!, game.Genre!, game.ReleaseYear.ToString(), game.GameStudio!, game.Sales.ToString("N0"));
            }
            else
            {
                PrintRow("null", "null", "null", "null", "null");
            }
        }
        PrintLine();
    }
    
    private static void PrintLine()
    {
        Console.WriteLine(new string('-', TableWidth));
    }

    private static void PrintRow(params string[] columns)
    {
        var width = (TableWidth - columns.Length) / columns.Length;
        var row = columns.Aggregate("|", (current, column) => current + AlignCentre(column, width) + "|");

        Console.WriteLine(row);
    }

    private static string AlignCentre(string text, int width)
    {
        text = text.Length > width ? string.Concat(text.AsSpan(0, width - 3), "...") : text;

        return string.IsNullOrEmpty(text) ? new string(' ', width) : text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
    }
}