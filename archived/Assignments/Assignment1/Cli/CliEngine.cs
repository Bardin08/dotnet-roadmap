using System.CommandLine;
using Assignment1.Cli.Commands;

namespace Assignment1.Cli;

internal class CliEngine
{
    internal void Execute()
    {
        var rootCommand = new RootCommand();
        rootCommand.AddCommand(new PlayCommand().GetDefinition());
        rootCommand.AddCommand(new ExitCommand().GetDefinition());
        rootCommand.AddCommand(new LeaderboardCommand().GetDefinition());

        while (true)
        {
            var input = GetInput();

            if (string.IsNullOrEmpty(input))
            {
                const string errorMessage = "Input can't be null. Please, write a valid command";
                Console.WriteLine(errorMessage);
            }

            rootCommand.Invoke(input!);
        }
    }

    private string? GetInput()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("> ");
        var input = Console.ReadLine();
        Console.ResetColor();
        return input;
    }
}