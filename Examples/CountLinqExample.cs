﻿using LINQ.Models;

namespace LINQ.Examples;

public class CountLinqExample : LinqExample
{
    protected override string Description => "We tellen het aantal games waarvan de uitgever Riot Games is";
    
    protected override void RunWithQuery(IEnumerable<Game> games)
    {
        // Skipped because not possible: https://stackoverflow.com/questions/17890729/how-can-i-write-take1-in-query-syntax
        throw new NotImplementedException();
    }

    protected override void RunWithMethod(IEnumerable<Game> games)
    {
        var amount = games.Count(game => game.GameStudio == "Riot Games");
        
        DisplayData(amount);
    }

    private static void DisplayData(int amount)
    {
        Console.WriteLine($"Het aantal games: {amount}");
    }
}