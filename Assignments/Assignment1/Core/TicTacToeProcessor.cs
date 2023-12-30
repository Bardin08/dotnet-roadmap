using System.Text.Json;

namespace Assignment1.Core;

internal class TicTacToeProcessor(
    PlayersProvider playersProvider,
    UserInputProvider inputProvider,
    Leaderboard leaderboard)
{
    internal void Process()
    {
        leaderboard.Load();
        leaderboard.PrintLeaderboard();

        var players = playersProvider.GetPlayers();

        leaderboard.AddIfNotExists(players.p1);
        leaderboard.AddIfNotExists(players.p2);

        var gameProcessor = new GameProcessor(inputProvider, players);
        var gameResult = gameProcessor.Play();

        if (gameResult.Winner is null)
        {
            Console.WriteLine("It's a draw!");

            leaderboard.Update(players.p1, isWinner: null);
            leaderboard.Update(players.p2, isWinner: null);
        }
        else
        {
            Console.WriteLine("Winner: {0}({1})",
                gameResult.Winner!.Value.Name,
                gameResult.Winner!.Value.Symbol);

            var winner = players.p1 == gameResult.Winner ? players.p1 : players.p2;
            var loser = players.p1 != gameResult.Winner ? players.p1 : players.p2;

            leaderboard.Update(winner, isWinner: true);
            leaderboard.Update(loser, isWinner: false);
        }

        leaderboard.Save();
        leaderboard.PrintLeaderboard();
    }
}