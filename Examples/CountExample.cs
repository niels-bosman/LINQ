﻿namespace LINQ.Examples;

public class CountExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We tellen het aantal games waarvan de uitgever Riot Games is";

    protected override void RunWithMethod()
    {
        var amount = Games.Count(game => game.GameStudio == "Riot Games");
        
        DisplayData(amount);
    }

    private static void DisplayData(int amount)
    {
        Console.WriteLine($"Het aantal games: {amount}");
    }
}