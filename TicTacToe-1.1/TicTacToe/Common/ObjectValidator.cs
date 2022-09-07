using System.Text.RegularExpressions;
using TicTacToe.Contracts;

namespace TicTacToe.Common
{
    public class ObjectValidator
    {
        private const string InvalidNameErrorMessage = "name should be more than 3 chars";
        private const string EqualNamesErrorMessage = "names should be different, chose another name";
        private const string InvalidMarkErrorMessage = "this box is already marked, choose another box";

        public static void CheckIfObjectIsNull(object obj, string errorMessage = GlobalConstants.EmptyString)
        {
            if (obj == null)
            {
                throw new NullReferenceException(GlobalConstants.NullReferenceErrorMessage);
            }

        }
        
        public static void CheckPlayerName(string name)
        {
            Regex nameRegex = new Regex(@".{3,}");

            if (!nameRegex.IsMatch(name))
            {
                throw new InvalidDataException(InvalidNameErrorMessage);
            }
        }

        public static void CheckIfNamesAreEqual(string firstPlayerName, string secondPlayerName)
        {
            if (firstPlayerName.Equals(secondPlayerName))
            {
                throw new InvalidCastException(EqualNamesErrorMessage);
            }
        }

        public static void IsMarked(IField field, Position position)
        {
            // TODO: logic to find certain position on field
            IMark fieldMark = field.GetFieldCertainPosition(position);

            if (fieldMark.Symbol == Symbol.X || fieldMark.Symbol == Symbol.O)
            {
                throw new InvalidDataException(InvalidMarkErrorMessage);
            }

        }
    }
}
