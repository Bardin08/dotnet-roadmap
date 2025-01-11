using System.CommandLine;
using System.CommandLine.Invocation;
using Assignment1.Core;

namespace Assignment1.Cli.Commands;

public class LeaderboardCommand : ICommandDefinition
{
    public string Name => "leaderboard";
    public string[] Aliases => ["lb"];
    public Option<object>[] Options => [];
    public Argument<object>[] Arguments => [];

    public Command GetDefinition()
    {
        var command = new Command(Name);

        foreach (var alias in Aliases)
        {
            command.AddAlias(alias);
        }

        var showCommand = new Command("show");
        showCommand.SetHandler(Show);
        command.AddCommand(showCommand);

        var resetCommand = new Command("reset");
        resetCommand.SetHandler(Reset);
        command.AddCommand(resetCommand);

        return command;
    }

    private void Show()
    {
        var leaderboard = new Leaderboard();
        leaderboard.Load();
        leaderboard.PrintLeaderboard();
    }

    private void Reset()
    {
        var leaderboard = new Leaderboard();
        leaderboard.Save();
    }
}