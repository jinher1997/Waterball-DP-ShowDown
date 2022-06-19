namespace ShowDown
{
    public abstract class Player
    {
        #region Fields
        protected string name;
        protected int point = 0;
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
        public void TakeTurn()
        {

        }
        public void gainPoint()
        {

        }
        public abstract void NameSelf();
        public abstract void Show(Card card);
        public abstract bool DecideWhetherToExchangeHands();
    }
}