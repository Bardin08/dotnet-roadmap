namespace Assignment1.Core;

internal class TicTacToeProcessor(
    PlayersProvider playersProvider,
    UserInputProvider inputProvider,
    Leaderboard leaderboard,
    GameMode mode)
{
    internal void Process()
    {
        leaderboard.Load();
        leaderboard.PrintLeaderboard();

        (PlayerDescriptor p1, PlayerDescriptor p2) players = mode switch
        {
            GameMode.AiOpponent => playersProvider.GetPlayerAndAi(),
            GameMode.TwoPlayers => playersProvider.GetPlayers()
        };

        EnsurePlayerInLeaderboard(players.p1);
        EnsurePlayerInLeaderboard(players.p2);

        var gameProcessor = new GameProcessor(inputProvider, players, GameMode.AiOpponent);
        var gameResult = gameProcessor.Play();

        UpdateLeaderboard(gameResult, players);
        leaderboard.PrintLeaderboard();
    }

    private void EnsurePlayerInLeaderboard(PlayerDescriptor player)
    {
        var playerAdded = leaderboard.AddIfNotExists(player);
        if (!playerAdded)
        {
            Console.WriteLine("Welcome back, {0}", player.Name);
        }
    }

    private void UpdateLeaderboard(
        GameResult gameResult,
        (PlayerDescriptor p1, PlayerDescriptor p2) players)
    {
        if (gameResult.Winner is null)
        {
            Console.WriteLine("It's a draw!");

            leaderboard.Update(players.p1, isWinner: null);
            leaderboard.Update(players.p2, isWinner: null);
        }
        else
        {
            Console.WriteLine("Winner: {0}({1})",
                gameResult.Winner!.Name,
                gameResult.Winner!.Symbol);

            var winner = players.p1 == gameResult.Winner ? players.p1 : players.p2;
            var loser = players.p1 != gameResult.Winner ? players.p1 : players.p2;

            leaderboard.Update(winner, isWinner: true);
            leaderboard.Update(loser, isWinner: false);
        }

        leaderboard.Save();
    }
}