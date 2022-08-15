namespace TicTacToe.Common
{
    public struct Position
    {
        public Position(int row, char col)
        {
            this.Row = row;
            this.Column = col;
        }

        public int Row { get; set; }

        public char Column { get; set; }
    }
}
