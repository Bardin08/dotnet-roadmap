namespace Assignment1.Core;

internal class PlayersProvider
{
    internal (PlayerDescriptor p1, PlayerDescriptor p2) GetPlayers()
    {
        return (GetPlayerInfo('X'), GetPlayerInfo('O'));
    }

    internal (PlayerDescriptor p1, PlayerDescriptor p2) GetPlayerAndAi()
    {
        return (GetPlayerInfo('X'), GetAiPlayerDescriptor('O'));
    }

    private PlayerDescriptor GetPlayerInfo(char symbol)
    {
        PlayerDescriptor? descriptor = null;
        do
        {
            Console.WriteLine("Enter player name (ex. Vlad): ");
            var playerName = Console.ReadLine();

            if (playerName is null)
            {
                continue;
            }

            descriptor = new PlayerDescriptor()
            {
                Name = playerName,
                Symbol = symbol
            };
        } while (descriptor is null);

        return descriptor;
    }

    private PlayerDescriptor GetAiPlayerDescriptor(char symbol)
    {
        return new PlayerDescriptor()
        {
            Name = "ai",
            Symbol = symbol,
            IsAi = true
        };
    }
}