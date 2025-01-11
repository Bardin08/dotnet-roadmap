using System.CommandLine;

namespace Assignment1.Cli.Commands;

internal interface ICommandDefinition
{
    public string Name { get; }
    public string[] Aliases { get; }
    public Option<object>[] Options { get; }
    public Argument<object>[] Arguments { get; }

    Command GetDefinition();
}