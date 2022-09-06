using System.Text.RegularExpressions;

namespace TicTacToe.Common
{
    public class ObjectValidator
    {
        private const string InvalidNameErrorMessage = "name should be more than 3 chars";
        private const string EqualNamesErrorMessage = "names should be different, chose another name";

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
    }
}
