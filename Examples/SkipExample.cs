namespace LINQ.Examples;

public class SkipExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We slaan de eerste twee games over in de lijst.";

    protected override void RunMethodVariant()
    {
        var list = Games.Skip(2);
        
        Display(list);
    }
}