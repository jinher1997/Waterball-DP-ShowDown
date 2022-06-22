namespace ShowDown
{
    public class Card
    {
        public Rank Rank { get; }
        public Suit Suit { get; }
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }

        public Card CompareTo(Card card)
        {
            // Compare the rank if ranks are equal then compare the suit
            if(Rank == card.Rank)
            {
                if(Suit > card.Suit)
                {
                    return this;
                }
                else
                {
                    return card;
                }
            }
            else
            {
                if(Rank > card.Rank)
                {
                    return this;
                }
                else
                {
                    return card;
                }
            }
        }
    }
}