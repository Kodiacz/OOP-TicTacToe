namespace TicTacToe.Common
{
    using TicTacToe.Contracts;
    using TicTacToe.Players;

    public class GameInputs
    {
        public ICollection<IPlayer> GetPlayers(int numberOfPlayers)
        {
            List<IPlayer> players = new List<IPlayer>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                string numberSuffix = i == 1 ? "-st" : "-nd";
                Console.Write($"Choose {i}{numberSuffix} player name: ");

                string playerName = Console.ReadLine();
                ObjectValidator.CheckPlayerName(playerName);

                Symbol symbol = (Symbol)i;
                IPlayer player = new Player(playerName, symbol);

                players.Add(player);

                Console.Clear();
            }

            ObjectValidator.CheckIfNamesAreEqual(players[0].Name, players[1].Name);

            return players;
        }
    }
}
