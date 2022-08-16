namespace TicTacToe.Common
{
    public class ObjectValidator
    {
        public static void CheckIfObjectIsNull(object obj, string errorMessage = GlobalConstants.EmptyString)
        {
            if (obj == null)
            {
                throw new NullReferenceException(GlobalConstants.NullReferenceErrorMessage);
            }
        }
    }
}
