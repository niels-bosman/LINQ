using LINQ.Examples;
using LINQ.Models;
using LINQ.Repositories;
using LINQ.Utils;

// Alle games ophalen
var games = new GameRepository().GetGames();

// LINQ functie vragen
Console.WriteLine("Welke LINQ functie wil je uitproberen? Opties: where, orderby, select, selectmany, join, groupby, count, min, max, sum, average, skip, take, first, firstordefault");
var function = Console.ReadLine();

ILinqExample example = function switch
{
    "where" => new WhereLinqExample(),
};

// LINQ Variant vragen
Console.WriteLine("Welke variant daarvan wil je proberen? Opties: method, query");
var variant = Console.ReadLine();

IEnumerable<Game> filteredList = variant switch
{
    "method" => example.WithMethod(games),
    "query" => example.WithQuery(games),
};

// Resultaat tonen
Console.WriteLine(example.Description);
GameTableGenerator.Generate(filteredList);

