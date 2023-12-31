using System.CommandLine;
using Assignment1.Core;

namespace Assignment1.Cli.Commands;

internal class PlayCommand : ICommandDefinition
{
    public string Name => "play";
    public string[] Aliases => [];
    public Option<object>[] Options => [];
    public Argument<object>[] Arguments => [];

    public Command GetDefinition()
    {
        var command = new Command("play")
        {
            Description = "This command executes tic-tac-toe logic",
        };

        var aiCommand = new Command("ai")
        {
            Description = "This command starts game with AI"
        };
        aiCommand.SetHandler(PlayWithAi);
        command.AddCommand(aiCommand);
        
        var twoPlayersCommand = new Command("real-opponent")
        {
            Description = "This command starts game for 2 players"
        };
        twoPlayersCommand.SetHandler(PlayTwoPlayers);
        command.AddCommand(twoPlayersCommand);
        
        return command;
    }

    private static void PlayWithAi()
    {
        Play(GameMode.AiOpponent);
    }
    
    private static void PlayTwoPlayers()
    {
        Play(GameMode.TwoPlayers);
    }
    
    private static void Play(GameMode mode)
    {
        var playersProvider = new PlayersProvider();
        var userInputProvider = new UserInputProvider();
        var leaderboard = new Leaderboard();

        var processor = new TicTacToeProcessor(
            playersProvider,
            userInputProvider,
            leaderboard,
            mode);

        processor.Process();
    }
}
