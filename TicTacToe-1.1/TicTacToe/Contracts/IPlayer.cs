using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface IPlayer
    {
        public string Name { get; }

        public Symbol Symbol { get; set; }

        public int Points { get; set; }
    }
}
