namespace ShowDown
{
    public class ShowDown
    {
        private Player[] players = new Player[4];
        private Deck deck;
        private Round[] rounds = new Round[13];

        public ShowDown(Player[] players)
        {
            this.players = players;
            deck = new Deck();
        }

        public void Start()
        {
            RequestPlayersNameThemselves();
            deck.Shuffle();
            DrawCardStage();
            ExecuteRounds();
            GameOver();
        }

        void DrawCardStage()
        {
            for (int i = 0; i < rounds.Length; i++)
            {
                foreach (Player player in players)
                {
                    player.hand.cards.Add(deck.DrawCard());
                }
            }
        }

        void ExecuteRounds()
        {
            for (int i = 0; i < rounds.Length; i++)
            {
                Console.WriteLine($"Round :{i + 1}");
                rounds[i] = new Round();
                rounds[i].Execute(players);
            }
        }

        void GameOver()
        {
            Console.WriteLine($"Winner is {DetermineWinner()}");
        }

        Player DetermineWinner()
        {
            var winner = players[0];
            for (int i = 1; i < players.Length; i++)
            {
                if(players[i].Point > winner.Point)
                {
                    winner = players[i];
                }
            }
            return winner;
        }

        void RequestPlayersNameThemselves()
        {
            for (int i = 0; i < players.Length; i++)
            {
                players[i].NameSelf();
            }
        }
    }
}