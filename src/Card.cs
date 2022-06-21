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

        // public int CompareTo(Card card)
        // {
        //     // Compare the rank if ranks are equal then compare the suit
        //     if(Rank == card.Rank)
        //     {

        //     }
        // }
    }
}