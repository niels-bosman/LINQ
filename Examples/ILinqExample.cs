using System.Collections;
using LINQ.Models;

namespace LINQ.Examples;

public interface ILinqExample
{
    public string? Description { get; }
    public List<Game> WithQuery(List<Game> games);
    
    public List<Game> WithMethod(List<Game> games);
}