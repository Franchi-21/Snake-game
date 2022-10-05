namespace SnakeGame
{
    partial class Snake
    {
        private List<Location> Serpent { get; set; }
        private MovKeys currentKey;
        public uint Score { get; private set; }

        public Snake(int x, int y)
        {
            Serpent = new List<Location> { new Location(x, y) };
            currentKey = MovKeys.NO_KEY_PRESSED;
            Score = 0;
        }

        public void ShowSnake()
        {
            foreach (Location point in Serpent)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Utilities.PrintChar(point.X, point.Y, "O");
                Console.ResetColor();
            }                                              
        }
    }
}
