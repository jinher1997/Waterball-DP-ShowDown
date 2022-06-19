namespace ShowDown
{
    public class ShowDown
    {
        private Player[] players = new Player[4];
        private Deck deck;
        public ShowDown(Player[] players)
        {
            this.players = players;
            deck = new Deck();
        }

        public void Start()
        {
            RequestPlayerNames();
            deck.Shuffle();
        }

        public void TakeTurn(Player player)
        {

        }

        public void PrintShowCards()
        {

        }

        public void GameOver()
        {
            
        }

        void RequestPlayerNames()
        {
            for (int turnOfPlayers = 0; turnOfPlayers < players.Length; turnOfPlayers++)
            {
               players[turnOfPlayers].NameSelf();
            }
        }
    }
}