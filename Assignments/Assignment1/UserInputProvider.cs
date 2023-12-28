namespace Assignment1;

internal class UserInputProvider
{
    internal MoveDescriptor GetMove(int threshold)
    {
        while (true)
        {
            try
            {
                Console.Write("Enter row and col (starting from 1) separated by space: ");
                var coordinates = Console.ReadLine()!.Split(' ')
                    .Select(int.Parse).ToArray();

                if (coordinates[0] <= threshold &&
                    coordinates[1] <= threshold)
                {
                    return new MoveDescriptor
                    {
                        Row = coordinates[0] - 1,
                        Col = coordinates[1] - 1
                    };
                }

                Console.WriteLine("Invalid input! Out of the game board!");
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}