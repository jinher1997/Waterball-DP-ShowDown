namespace ShowDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4];
            for (int i = 0; i < 3; i++)
            {
                players[i] = new HumanPlayer();
            }
            players[3] = new AIPlayer();
            var game = new ShowDown(players);
            game.Start();
        }
    }
}