namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        void Initializer(IPlayer firstPlayer, IPlayer secondPlayer, string firstPlayerName, string secondPlayerName);
    }
}
