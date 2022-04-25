using LINQ.Examples;

namespace LINQ.Utils;

public static class View
{
    public static Example AskExample()
    {
        Console.Clear();
        
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
        
        var type = Console.ReadLine();
        
        Example example = type switch
        {
            "where" => new WhereExample(),
            "orderby" => new OrderByExample(),
            "select" => new SelectExample(),
            "selectmany" => new SelectManyExample(),
            "join" => new JoinExample(),
            "outerjoin" => new OuterJoinExample(), // TODO
            "groupby" => new GroupByExample(), // TODO
            "count" => new CountExample(),
            "min" => new MinExample(),
            "max" => new MaxExample(),
            "sum" => new SumExample(),
            "average" => new AverageExample(),
            "aggregate" => new AggregateExample(),
            "skip" => new SkipExample(),
            "take" => new TakeExample(),
            "first" => new FirstExample(),
            "firstordefault" => new FirstOrDefaultExample(),
            "distinct" => new DistinctExample(),
            "custom" => new CustomExample(),
            _ => throw new ArgumentOutOfRangeException()
        };
        
        Console.Clear();

        return example;
    }

    public static string? AskType()
    {
        Console.WriteLine(
            "Welke variant daarvan wil je proberen? Opties: \n" +
            "- method \n" +
            "- query"
        );

        var type = Console.ReadLine();
        Console.Clear();

        return type;
    }

    public static bool AskToContinue()
    {
        Console.WriteLine(
            "\n\n" + 
            "Wil je nog een voorbeeld proberen? (Y/n)"
        );

        var resume = Console.ReadLine();

        return resume != null && resume.ToLower().Contains('y');
    }
}