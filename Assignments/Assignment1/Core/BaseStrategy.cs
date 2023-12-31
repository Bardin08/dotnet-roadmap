namespace Assignment1.Core;

internal abstract class BaseStrategy : IGameStrategy
{
    public abstract void DoStep(GameField gameField, PlayerDescriptor player);
}