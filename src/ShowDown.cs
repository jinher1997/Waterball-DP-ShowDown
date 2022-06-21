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
            StartRound();
        }

        void StartRound(int roundNumber = 0)
        {
            rounds[roundNumber] = new Round();
            rounds[roundNumber].Execute(players);
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

        public void TakeTurn(Player player)
        {

        }

        public void PrintShowCards()
        {

        }

        public void GameOver()
        {

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