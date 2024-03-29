﻿namespace LINQ.Examples;

public class WhereExample : Example
{
    protected override string Description => "We filteren de games die nieuwe zijn dan 2017";

    protected override void RunQueryVariant()
    {
        var list =
            from game in Games
            where game.ReleaseYear > 2017
            select game;

        Display(list);
    }

    protected override void RunMethodVariant()
    {
        var list = Games.Where(game => game.ReleaseYear > 2017);

        Display(list);
    }
}