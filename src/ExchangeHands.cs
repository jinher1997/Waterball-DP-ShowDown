namespace ShowDown
{
    public class ExchangeHands
    {
        private Player exchanger;
        private Player exchangee;
        public ExchangeHands(Player exchanger ,Player exchangee)
        {
            this.exchanger = exchanger;
            this.exchangee = exchangee;
            exchanger.onTakeTurn += CountDown;
        }
        private int countdown = 3;
        public void CountDown()
        {
            countdown--;
            if(countdown == 0)
            {
                exchanger.onTakeTurn -= CountDown;
                exchanger.GiveBackHandsTo(exchangee);
            }
        }
    }
}