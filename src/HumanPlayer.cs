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

        protected override Card Show()
        {
            //Print out all cards in hand and ask user to select a card with index
            Console.WriteLine("Your cards are:");
            for (int i = 0; i < hand.cards.Count; i++)
            {
                Console.WriteLine($"{i}: {hand.cards[i]}");
            }
            Console.WriteLine("What card do you want to show?");
            int index = int.Parse(Console.ReadLine());
            //Tell user what card they selected
            Console.WriteLine($"You showed {hand.cards[index]}");
            var temp = hand.cards[index];
            hand.cards.RemoveAt(index);
            return temp;
        }
    }
}