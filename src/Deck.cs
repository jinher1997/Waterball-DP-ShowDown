namespace ShowDown
{
    public class Deck
    {
        protected Stack<Card> cards = new Stack<Card>();
        
        public int GetDeckCardLength()
        {
            return cards.Count;
        }

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Push(new Card((Rank)j, (Suit)i));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            var newCards = cards.ToList();
            for (int i = 0; i < newCards.Count; i++)
            {
                int randomIndex = random.Next(newCards.Count);
                Card temp = newCards[i];
                newCards[i] = newCards[randomIndex];
                newCards[randomIndex] = temp;
            }
            cards = new Stack<Card>(newCards);
        }

        public Card DrawCard()
        {
            return cards.Pop();
        }

    }
}