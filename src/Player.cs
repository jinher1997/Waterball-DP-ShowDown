namespace ShowDown
{
    public abstract class Player
    {
        #region Fields
        protected string name;
        protected int point = 0;
        private int exchangeHandsChance = 1;
        public Hand hand = new Hand();
        public Player? next;

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
        public Card TakeTurn()
        {
            // if (HaveChangeToExchangeHands()) if (DecideWhetherToExchangeHands());
            return Show();
        }

        public void gainPoint()
        {
            point++;
        }

        bool HaveChangeToExchangeHands()
        {
            return exchangeHandsChance == 1;
        }

        public abstract void NameSelf();
        protected abstract Card Show();
        public abstract bool DecideWhetherToExchangeHands();
    }
}