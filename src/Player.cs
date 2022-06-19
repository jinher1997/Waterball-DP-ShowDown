namespace ShowDown
{
    public abstract class Player
    {
        #region Fields
        protected string name;
        protected int point;
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

        protected Card[]? hands;

        #endregion

        public abstract void NameHimself();
    }

    public class HumanPlayer : Player
    {
        public override void NameHimself()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }
    }

    public class AIPlayer : Player
    {
        public override void NameHimself()
        {
            name = "Computer";
        }
    }
}