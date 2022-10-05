namespace SnakeGame
{
    partial class Snake
    {
        public void Move()
        {
            List<Location> newSnakeLocation = new() { GetNewPosition() };
            newSnakeLocation.AddRange(Serpent);
            newSnakeLocation.Remove(newSnakeLocation.Last());
            Serpent = newSnakeLocation;
        }

        public void RecognizeMovementKey(ConsoleKey keyPressed)
        {
            switch (keyPressed)
            {
                case ConsoleKey.DownArrow:
                    currentKey = MovKeys.DOWN;
                    break;
                case ConsoleKey.UpArrow:
                    currentKey = MovKeys.UP;
                    break;
                case ConsoleKey.LeftArrow:
                    currentKey = MovKeys.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    currentKey = MovKeys.RIGHT;
                    break;
            }
        }

        private Location GetNewPosition()
        {
            int x = Serpent.First().X;
            int y = Serpent.First().Y;
            switch (currentKey)
            {
                case MovKeys.UP:
                    y--;
                    break;
                case MovKeys.DOWN:
                    y++;
                    break;
                case MovKeys.LEFT:
                    x--;
                    break;
                case MovKeys.RIGHT:
                    x++;
                    break;
            }
            return new Location(x, y);
        }
    }
}
