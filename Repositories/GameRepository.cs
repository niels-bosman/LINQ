using LINQ.Models;

namespace LINQ.Repositories;

public class GameRepository
{
    private List<Game> Games { get; }
    
    public GameRepository()
    {
        Games = new List<Game>
        {
            new()
            {
                Name = "Grand theft auto 5",
                Sales = 160000000,
                Genre = "Shooter",
                GameStudio = "Rockstar",
                ReleaseYear = 2013,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                    Platform.Ps3,
                    Platform.Ps4,
                    Platform.Xbox360,
                    Platform.XboxOne
                }
            },
            new()
            {
                Name = "Sea of Thieves",
                Sales = 5000000,
                Genre = "Action-adventure",
                GameStudio = "Rare",
                ReleaseYear = 2018,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                    Platform.XboxOne
                }
            },
            new()
            {
                Name = "League of Legends",
                Sales = 115000000,
                Genre = "MOBA",
                GameStudio = "Riot Games",
                ReleaseYear = 2009,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                }
            },
            new()
            {
                Name = "Counter-Strike: Global Offensive",
                Sales = 414000000,
                Genre = "Shooter",
                GameStudio = "Valve",
                ReleaseYear = 2012,
                Platforms = new List<Platform>
                {
                    Platform.Pc
                }
            },
            new()
            {
                Name = "Valorant",
                Sales = 15000000,
                Genre = "Shooter",
                GameStudio = "Riot Games",
                ReleaseYear = 2020,
                Platforms = new List<Platform>
                {
                    Platform.Pc
                }
            },
            new()
            {
                Name = "FIFA 21",
                Sales = 31000000,
                Genre = "Sports",
                GameStudio = "Electronic Arts",
                ReleaseYear = 2020,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                    Platform.Ps4,
                    Platform.Ps5,
                    Platform.XboxOne,
                    Platform.NintendoSwitch
                }
            },
            new()
            {
                Name = "F1 2021",
                Sales = 50000000,
                Genre = "Sports",
                GameStudio = "Electronic Arts",
                ReleaseYear = 2021,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                    Platform.Ps4,
                    Platform.Ps5,
                    Platform.XboxOne
                }
            },
            new()
            {
                Name = "Dota 2",
                Sales = 800000,
                Genre = "MOBA",
                GameStudio = "Valve",
                ReleaseYear = 2013,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                }
            },
            new()
            {
                Name = "Overwatch",
                Sales = 15000000,
                Genre = "Shooter",
                GameStudio = "Blizzard",
                ReleaseYear = 2016,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                }
            },
            new()
            {
                Name = "Fortnite",
                Sales = 350000000,
                Genre = "Battle Royale",
                GameStudio = "Epic Games",
                ReleaseYear = 2017,
                Platforms = new List<Platform>
                {
                    Platform.Pc,
                    Platform.NintendoSwitch,
                    Platform.Ps4,
                    Platform.Ps5,
                    Platform.XboxOne
                }
            },
            new()
            {
                Name = "Pokémon Legends: Arceus",
                Sales = 645000,
                Genre = "Open world",
                GameStudio = "Game Freak",
                ReleaseYear = 2022,
                Platforms = new List<Platform>
                {
                    Platform.NintendoSwitch,
                }
            },
            new()
            {
                Name = "Kirby en de Vergeten Wereld",
                Sales = 320000,
                Genre = "Platformspel",
                GameStudio = "HAL Laboratory",
                ReleaseYear = 2022,
                Platforms = new List<Platform>
                {
                    Platform.NintendoSwitch,
                }
            },
        };
    }
    
    public List<Game> GetGames()
    {
        return Games;
    }
}