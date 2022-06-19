namespace ShowDown
{
    public class HumanPlayer : Player
    {
        public override bool DecideWhetherToExchangeHands()
        {
            throw new NotImplementedException();
        }

        public override void NameSelf()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }

        public override void Show(Card card)
        {
            throw new NotImplementedException();
        }
    }
}