namespace Assignment1;

internal class PlayersProvider
{
    internal (PlayerDescriptor p1, PlayerDescriptor p2) GetPlayers()
    {
        return (GetPlayerInfo('X'), GetPlayerInfo('O'));
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

        return descriptor.Value;
    }
}