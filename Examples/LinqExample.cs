﻿using System.Collections;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Examples;

public abstract class LinqExample
{
    protected abstract string? Description { get; }

    protected abstract void RunWithQuery(IEnumerable<Game> games);

    protected abstract void RunWithMethod(IEnumerable<Game> games);

    private void ShowDescription() => Console.WriteLine(Description);

    protected static void DisplayData(IEnumerable<Game> games) => GameTableGenerator.Generate(games);

    public void Run(IEnumerable<Game> games)
    {
        var type = Console.ReadLine();
        Console.Clear();
        ShowDescription();

        switch (type)
        {
            case "method":
                RunWithMethod(games);
                break;
            case "query":
                RunWithQuery(games);
                break;
        }
    }
}