namespace ShowDown
{
    public abstract class Player
    {
        #region Fields
        protected string name;
        protected int point = 0;
        private int exchangeHandsChance = 1;
        public Hand hand = new Hand();
        public Action? onTakeTurn;

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Point
        {
            get { return point; }
            set { point = value; }
        }


        #endregion
        public void TakeTurnToDecideWhetherToExchangeHands(Player[] otherPlayers)
        {
            onTakeTurn?.Invoke();
            if (HaveChanceToExchangeHands())
                if (DecideWhetherToExchangeHands())
                    exchangeHandsChance --;
                    ExchangeHands(otherPlayers);
        }

        protected abstract void ExchangeHands(Player[] otherPlayers);

        public void GiveBackHandsTo(Player personOfferedForExchange)
        {
            var temp = hand;
            hand = personOfferedForExchange.hand;
            personOfferedForExchange.hand = temp;
        }

        public void GainPoint()
        {
            point++;
        }

        bool HaveChanceToExchangeHands()
        {
            return exchangeHandsChance > 0;
        }

        public abstract void NameSelf();
        public abstract Card Show();
        public abstract bool DecideWhetherToExchangeHands();
    }
}