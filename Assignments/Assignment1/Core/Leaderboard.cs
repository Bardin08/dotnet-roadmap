using System.Text.Json;

namespace Assignment1.Core;

internal class Leaderboard
{
    private const string Path = "../leaderboard.json";

    private readonly Dictionary<string, LeaderboardRecord> _leaderboardRecords = new();

    internal void AddIfNotExists(PlayerDescriptor player)
    {
        if (!_leaderboardRecords.ContainsKey(player.Name))
        {
            _leaderboardRecords.Add(player.Name, new LeaderboardRecord(player.Name));
        }
    }

    internal void Update(PlayerDescriptor player, bool? isWinner)
    {
        var record = _leaderboardRecords[player.Name];

        if (isWinner is null)
            _leaderboardRecords[player.Name] = record with { Draws = record.Draws + 1 };
        else if (isWinner.Value)
            _leaderboardRecords[player.Name] = record with { Wins = record.Wins + 1 };
        else
            _leaderboardRecords[player.Name] = record with { Loses = record.Loses + 1 };
    }

    internal void Save()
    {
        File.WriteAllText(Path, JsonSerializer.Serialize(_leaderboardRecords));
    }

    internal void Load()
    {
        _leaderboardRecords.Clear();
        var json = File.ReadAllText(Path);

        var records = JsonSerializer.Deserialize<Dictionary<string, LeaderboardRecord>>(json);
        foreach (var record in records!)
        {
            _leaderboardRecords.Add(record.Key, record.Value);
        }
    }

    internal void PrintLeaderboard()
    {
        Console.WriteLine("{0,-10} {1,5} {2,5} {3,5}", "Player", "Wins", "Loses", "Draws");
        Console.WriteLine(new string('-', 30));

        foreach (var record in _leaderboardRecords.Values)
        {
            Console.WriteLine("{0,-10} {1,5} {2,5} {3,5}", record.Player, record.Wins, record.Loses, record.Draws);
        }
    }
}