using System.CommandLine;
using System.CommandLine.Parsing;
using Assignment1.Cli.Commands;

namespace Assignment1.Cli;

internal class CliEngine
{
    internal static void Execute()
    {
        var rootCommand = new RootCommand();
        rootCommand.AddCommand(new PlayCommand().GetDefinition());
        rootCommand.AddCommand(new ExitCommand().GetDefinition());

        while (true)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                const string errorMessage = "Input can't be null. Please, write a valid command";
                Console.WriteLine(errorMessage);
            }

            rootCommand.Invoke(input!);
        }
    }
}