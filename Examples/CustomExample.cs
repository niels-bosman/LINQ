using LINQ.Utils;

namespace LINQ.Examples;

public class CustomExample : WithoutQuerySyntaxExample
{
    protected override string Description => "We tonen alle games die in het huidige jaar gereleased zijn.";

    protected override void RunMethodVariant()
    {
        var list = Games.WhereReleasedThisYear();
        
        Display(list);
    }
}