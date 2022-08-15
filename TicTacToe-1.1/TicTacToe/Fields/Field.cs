﻿namespace TicTacToe.Fields
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;
    using TicTacToe.Marks;

    public class Field : IField
    {
        private IMark[,] field;

        public Field(int row, int col)
        {
            this.TotalRows = row;
            this.TotalCols = col;
            this.field = new Mark[this.TotalRows, this.TotalCols];
            InitializeFieldArray();
        }

        public int TotalRows { get; set; }

        public int TotalCols { get; set; }

        public void MarkSymbol(IMark mark, Position position)
        {
            ObjectValidator.CheckIfObjectIsNull(mark);
            this.CheckIfPositionIsValid(position);

            int arrRow = GetArrayRowPosition(position);
            int arrCol = GetArrayColumnPosition(position);

            this.field[arrRow, arrCol].Symbol = mark.Symbol;
        }

        public void DrawFieldOnConsole()
        {
            for (int row = 0; row < this.TotalRows; row++)
            {
                for (int col = 0; col < this.TotalCols; col++)
                {
                    Console.Write(this.field[row, col].Symbol);
                }

                Console.WriteLine();
            }
        }

        private int GetArrayRowPosition(Position position)
        {
            return this.TotalRows - position.Row;
        }

        private int GetArrayColumnPosition(Position position)
        {
            return position.Column - 'a';
        }

        private void CheckIfPositionIsValid(Position position)
        {
            if (position.Row < GlobalConstants.StandartMinimumRowLengthOnField || 
                position.Row > GlobalConstants.StandartMaximumRowLengthOnField)
            {
                throw new IndexOutOfRangeException("Selected row position on the field is not valid");
            }

            if (position.Column < GlobalConstants.StandartMinimumColumnLengthOnField || 
                position.Column > GlobalConstants.StandartMaximumColumnLengthOnField)
            {
                throw new IndexOutOfRangeException("Selected column position on the field is not valid");
            }
        }

        private void InitializeFieldArray()
        {
            for (int row = 0; row < this.TotalRows; row++)
            {
                for (int col = 0; col < this.TotalCols; col++)
                {
                    this.field[row, col] = new Mark();
                }
            }
        }
    }
}
