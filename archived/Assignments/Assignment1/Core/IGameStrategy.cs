namespace Assignment1.Core;

internal interface IGameStrategy
{
    void DoStep(GameField gameField, PlayerDescriptor player);
}