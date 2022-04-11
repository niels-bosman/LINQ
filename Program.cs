using LINQ.Examples;
using LINQ.Models;
using LINQ.Repositories;
using LINQ.Utils;

// Alle games ophalen
var games = new GameRepository().GetGames();

// LINQ functie vragen
Console.WriteLine("Welke LINQ functie wil je uitproberen? Opties: where, orderby, select, selectmany, join, groupby, count, min, max, sum, average, skip, take, first, firstordefault");

ILinqExample example = Console.ReadLine() switch
{
    "where" => new WhereLinqExample(),
    "orderby" => new OrderByLinqExample()
};

Console.Clear();

// LINQ Variant vragen
Console.WriteLine("Welke variant daarvan wil je proberen? Opties: method, query");

IEnumerable<Game> filteredList = Console.ReadLine() switch
{
    "method" => example.WithMethod(games),
    "query" => example.WithQuery(games),
};

Console.Clear();

// Resultaat tonen
Console.WriteLine(example.Description);
GameTableGenerator.Generate(filteredList);

