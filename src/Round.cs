using System;
namespace ShowDown
{
    public class Round
    {
        public void Execute(Player[] players)
        {
            Card[] cards = new Card[4];
            for (int i = 0; i < players.Length; i++)
            {
                Player currentPlayer = players[i];
                var otherPlayers = players.Where(player => player != currentPlayer).ToArray();
                currentPlayer.TakeTurnToDecideWhetherToExchangeHands(otherPlayers);
            }

            for (int playerIndex = 0; playerIndex < players.Length; playerIndex++)
            {
                Player currentPlayer = players[playerIndex];
                cards[playerIndex] = currentPlayer.Show();
            }

            //Compare all cards and determine the winner
            int highestCardIndex = 0;
            for (int cardIndex = 1; cardIndex < cards.Length; cardIndex++)
            {
                highestCardIndex = Array.IndexOf(cards, cards[highestCardIndex].CompareTo(cards[cardIndex]));
            }
            players[highestCardIndex].GainPoint();
        }
    }
}