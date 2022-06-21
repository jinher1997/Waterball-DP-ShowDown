namespace ShowDown
{
    public class AIPlayer : Player
    {
        public override bool DecideWhetherToExchangeHands()
        {
            //randomly decide whether to exchange hands
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            if (randomNumber == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            Console.WriteLine($"{Name} showed {hand.cards[randomIndex]}");
            hand.cards.RemoveAt(randomIndex);
            return temp;
        }
    }
}