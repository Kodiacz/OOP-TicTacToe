using TicTacToe.Contracts;

namespace TicTacToe.Common
{
    public class EngineLogic
    {
        public static bool CheckRowForMatch(Symbol symbol, IField EngineField)
        {
            IMark[,] field = EngineField.GetField;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col].Symbol == Symbol.Empty || field[row, col].Symbol != symbol)
                    {
                        break;
                    }
                    else if (col == field.GetLength(1) - 1)
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        public static bool CheckColumnForMatch(Symbol symbol, IField EngineField)
        {
            IMark[,] field = EngineField.GetField;

            for (int col = 0; col < field.GetLength(1); col++)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {
                    if (field[row, col].Symbol == Symbol.Empty || field[row, col].Symbol != symbol)
                    {
                        break;
                    }
                    else if (row == field.GetLength(0) - 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool CheckLeftRightDiagonalForMatch(Symbol symbol, IField EngineField)
        {
            IMark[,] field = EngineField.GetField;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (field[i, i].Symbol == Symbol.Empty || field[i, i].Symbol != symbol)
                {
                    break;
                }
                else if (i == field.GetLength(0) - 1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckRightLeftDiagonalForMatch(Symbol symbol, IField EngineField)
        {
            IMark[,] field = EngineField.GetField;

            for (int row = 0, col = field.GetLength(1) - 1; row < field.GetLength(1); row++, col--)
            {
                if (field[row, col].Symbol == Symbol.Empty || field[row, col].Symbol != symbol)
                {
                    break;
                }
                else if (row == field.GetLength(0) - 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
