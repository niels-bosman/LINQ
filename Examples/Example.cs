using System.Collections;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Examples;

public abstract class Example
{
    protected abstract string? Description { get; }
    
    protected IEnumerable<Game> Games { get; set; }

    protected abstract void RunWithQuery();

    protected abstract void RunWithMethod();

    private void ShowDescription() => Console.WriteLine(Description);

    protected static void DisplayData(IEnumerable<Game?> games) => GameTableGenerator.Generate(games);

    public void Run(string? type, IEnumerable<Game> games)
    {
        Games = games;
        ShowDescription();

        switch (type)
        {
            case "method":
                RunWithMethod();
                break;
            case "query":
                RunWithQuery();
                break;
        }
    }
}