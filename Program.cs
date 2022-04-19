using LINQ.Examples;
using LINQ.Repositories;

var games = new GameRepository().GetGames();

Console.WriteLine(
    "Welke LINQ functie wil je uitproberen? Opties: \n" +
    "- where \n" +
    "- orderby \n" +
    "- select \n" +
    "- selectmany \n" +
    "- join \n" +
    "- outerjoin \n" +
    "- groupby \n" +
    "- count \n" +
    "- min \n" +
    "- max \n" +
    "- sum \n" +
    "- average \n" +
    "- aggregate \n" +
    "- skip \n" +
    "- take \n" +
    "- first \n" +
    "- firstordefault \n" +
    "- distinct \n" +
    "- custom"
);

LinqExample example = Console.ReadLine() switch
{
    "where" => new WhereLinqExample(),
    "orderby" => new OrderByLinqExample(),
    "select" => new SelectLinqExample(),
    "selectmany" => new SelectManyLinqExample(),
    "join" => new JoinLinqExample(), // TODO
    "outerjoin" => new OuterJoinLinqExample(), // TODO
    "count" => new CountLinqExample(),
    "min" => new MinLinqExample(),
    "max" => new MaxLinqExample(),
    "sum" => new SumLinqExample(),
    "average" => new AverageLinqLinqExample(),
    "aggregate" => new AggregateLinqExample(),
    "skip" => new SkipLinqExample(),
    "take" => new TakeLinqExample(),
    "first" => new FirstLinqExample(),
    "firstordefault" => new FirstOrDefaultLinqExample(),
    "distinct" => new DistinctLinqExample(),
    "custom" => new CustomLinqExample(), // TODO
};

Console.Clear();

Console.WriteLine("Welke variant daarvan wil je proberen? Opties: method, query");

example.Run(games);
