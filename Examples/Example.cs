using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Examples;

public abstract class Example
{
    protected abstract string? Description { get; }
    
    protected IEnumerable<Game> Games { get; set; }

    protected abstract void RunQueryVariant();

    protected abstract void RunMethodVariant();

    private void ShowDescription() => Console.WriteLine(Description);

    protected static void Display(IEnumerable<Game?> games) => GameTableGenerator.Generate(games);

    public void Run(string? type, IEnumerable<Game> games)
    {
        Games = games;
        ShowDescription();

        switch (type)
        {
            case "method":
                RunMethodVariant();
                break;
            case "query":
                RunQueryVariant();
                break;
        }
    }
}