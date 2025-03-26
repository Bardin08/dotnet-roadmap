using System.CommandLine;

namespace Assignment1.Cli.Commands;

internal class ExitCommand : ICommandDefinition
{
    public string Name => "exit";
    public string[] Aliases => [];
    public Option<object>[] Options => [];
    public Argument<object>[] Arguments => [];

    public Command GetDefinition()
    {
        var command = new Command(Name);
        command.SetHandler(() =>
        {
            Console.WriteLine("Application shutdown..");
            Environment.Exit(0);
        });
        return command;
    }
}