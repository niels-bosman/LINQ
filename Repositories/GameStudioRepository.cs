using LINQ.Models;

namespace LINQ.Repositories;

public class GameStudioRepository
{
    private List<GameStudio> GameStudios { get; }
    
    public GameStudioRepository()
    {
        GameStudios = new List<GameStudio>
        {
            new() {
                Name = "Rockstar",
                Employees = 4751,
                Headquarters = "New York City",
                YearFounded = 1998,
            },
            new() {
                Name = "Rare",
                Employees = 257,
                Headquarters = "Twycross",
                YearFounded = 1985,
            },
            new() {
                Name = "Riot Games",
                Employees = 6025,
                Headquarters = "West Los Angeles",
                YearFounded = 2006,
            },
            new() {
                Name = "Valve",
                Employees = 1054,
                Headquarters = "Bellevue",
                YearFounded = 1996,
            },
            new() {
                Name = "Electronic Arts",
                Employees = 27942,
                Headquarters = "Redwood City",
                YearFounded = 1982,
            },
            new() {
                Name = "Blizzard",
                Employees = 5294,
                Headquarters = "Irvine",
                YearFounded = 1991,
            },
            new() {
                Name = "Epic Games",
                Employees = 6614,
                Headquarters = "Cary",
                YearFounded = 1991,
            },
            new() {
                Name = "Game Freak",
                Employees = 6614,
                Headquarters = "Chiyoda",
                YearFounded = 1989,
            },
        };
    }
    
    public List<GameStudio> GetGameStudios()
    {
        return GameStudios;
    }
}