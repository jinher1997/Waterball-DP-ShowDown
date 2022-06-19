namespace ShowDown
{
    public class ShowDown
    {
        private Player[] players;
        public void Start()
        {
            
        }

        void RequestPlayerNames()
        {
            for (int i = 0; i < players.Length; i++)
            {
               players[i].NameHimself();
            }
        }
    }
}