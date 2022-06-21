namespace ShowDown
{
    public class Round
    {
        public void Execute(Player[] players)
        {
            Card[] cards = new Card[4];
            for (int i = 0; i < players.Length; i++)
            {
                Player player = players[i];
                player.TakeTurn();
            }

            //Compare all cards and determine the winner
            

            // int highestCardIndex;
            // for (int cardIndex = 0; cardIndex < length; cardIndex++)
            // {
            //     highestCardIndex = cardIndex;
            //     for (int i = cardIndex + 1; i < length; i++)
            //     {
            //         if (cards[i].CompareTo(cards[highestCardIndex]) > 0)
            //         {
            //             highestCardIndex = i;
            //         }
            //     }

            // }
        }
    }
}