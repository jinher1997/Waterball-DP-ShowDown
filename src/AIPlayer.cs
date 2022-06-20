namespace ShowDown
{
    public class AIPlayer : Player
    {
        public override bool DecideWhetherToExchangeHands()
        {
            throw new NotImplementedException();
        }

        public override void NameSelf()
        {
            var random = new Random();
            Name = $"Computer{random.Next(1, 100)}";
        }

        protected override Card Show()
        {
            var random = new Random();
            int randomIndex = random.Next(0, hand.cards.Count);
            var temp = hand.cards[randomIndex];
            hand.cards.RemoveAt(randomIndex);
            return temp;
        }
    }
}