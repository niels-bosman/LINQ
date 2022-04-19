using LINQ.Examples;
using LINQ.Repositories;

// Alle games ophalen
var games = new GameRepository().GetGames();

// LINQ functie vragen
Console.WriteLine("Welke LINQ functie wil je uitproberen? Opties: where, orderby, select, selectmany, join, groupby, count, min, max, sum, average, aggregate, skip, take, first, firstordefault");

LinqExample example = Console.ReadLine() switch
{
    "where" => new WhereLinqExample(),
    "orderby" => new OrderByLinqExample(),
    "select" => new SelectLinqExample(),
    "selectmany" => new SelectManyLinqExample(),
    "count" => new CountLinqExample(),
    "min" => new MinLinqExample(),
    "max" => new MaxLinqExample(),
    "sum" => new SumLinqExample(),
    "average" => new AverageLinqExample(),
    "aggregate" => new AggregateLinqExample(),
};

Console.Clear();

// LINQ Variant vragen
Console.WriteLine("Welke variant daarvan wil je proberen? Opties: method, query");

example.Run(Console.ReadLine(), games);