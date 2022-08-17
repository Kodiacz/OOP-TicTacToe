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

                IPlayer player = new Player(playerName);
                players.Add(player);
            }

            return players;
        }
    }
}
