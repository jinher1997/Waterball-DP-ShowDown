namespace ShowDown
{
    public class ExchangeHands
    {
        private Player exchanger;
        private Player personOfferedForExchange;
        public ExchangeHands(Player exchanger ,Player personOfferedForExchange)
        {
            this.exchanger = exchanger;
            this.personOfferedForExchange = personOfferedForExchange;
            exchanger.onTakeTurn += CountDown;
        }
        private int countdown = 3;
        public void CountDown()
        {
            countdown--;
            if(countdown == 0)
            {
                exchanger.onTakeTurn -= CountDown;
                exchanger.GiveBackHandsTo(personOfferedForExchange);
            }
        }
    }
}