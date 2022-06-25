namespace ShowDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4] { new HumanPlayer(), new HumanPlayer(), new HumanPlayer(), new AIPlayer() };
            var game = new ShowDown(players);
            game.Start();
        }
    }
}