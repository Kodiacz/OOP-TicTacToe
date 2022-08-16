namespace TicTacToe.Contracts
{
    using TicTacToe.Common;

    public interface IField
    {
        public int TotalRows { get; }

        public int TotalCols { get; }

        public IMark[,] GetField { get; }

        public void MarkSymbol(IMark mark, Position position);
    }
}
