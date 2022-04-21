namespace LINQ.Examples;

public abstract class WithoutQuerySyntaxExample : Example
{
    protected override void RunQueryVariant()
    {
        Console.WriteLine("Dit voorbeeld heeft niet de mogelijkheid tot query syntax, gebruikt method syntax als alternatief.");
        
        RunMethodVariant();
    }
}