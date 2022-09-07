namespace TicTacToe.Contracts
{
    using TicTacToe.Common;

    public interface IField
    {
        public int TotalRows { get; }

        public int TotalCols { get; }

        public void MarkSymbol(IMark mark, Position position);

        public IMark GetFieldCertainPosition(Position position);

        public IMark[,] GetField { get; }
    }
}
