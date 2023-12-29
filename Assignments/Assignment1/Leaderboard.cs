using System.Text.Json;

namespace Assignment1;

internal class Leaderboard
{
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
        const string path = "../leaderboard.json";
        File.WriteAllText(path, JsonSerializer.Serialize(_leaderboardRecords));
    }
}