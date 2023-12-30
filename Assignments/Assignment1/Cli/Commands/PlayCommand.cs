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

        command.SetHandler(Play);
        return command;
    }

    private static void Play()
    {
        var playersProvider = new PlayersProvider();
        var userInputProvider = new UserInputProvider();
        var leaderboard = new Leaderboard();

        var processor = new TicTacToeProcessor(
            playersProvider,
            userInputProvider,
            leaderboard);

        processor.Process();
    }
}
