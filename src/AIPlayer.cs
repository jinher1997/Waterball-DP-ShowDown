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
            Name = "Computer";
        }

        public override void Show(Card card)
        {
            throw new NotImplementedException();
        }
    }
}