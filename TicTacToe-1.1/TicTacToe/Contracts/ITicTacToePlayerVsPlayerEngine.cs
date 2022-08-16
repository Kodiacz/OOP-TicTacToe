namespace TicTacToe.Contracts
{
    public interface ITicTacToePlayerVsPlayerEngine : ITicTacToeEngine
    {
        IField Field { get; }

        IPlayer FirstPlayer { get; }

        IPlayer SecondPlayer { get; }
    }
}
