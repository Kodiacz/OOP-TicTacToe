namespace TicTacToe.Contracts
{
    using TicTacToe.Common;

    public interface IField
    {
        public int TotalRows { get; set; }

        public int TotalCols { get; set; }

        public void MarkSymbol(IMark mark, Position position);

        public void DrawFieldOnConsole();
    }
}
