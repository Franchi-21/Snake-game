namespace SnakeGame
{
    internal class Program
    {
        public static void Main()
        {
            GameTable gameTable = new(20, 20);
            Snake snake = new(10, 10);
            Apple apple = new();
            ConsoleKeyInfo keyPressed;
            do 
            {            
                Console.Clear();
                Utilities.PrintChar(22, 0, $"Puntaje: {snake.Score}");
                snake.ShowSnake();
                gameTable.ShowGameTable();
                apple.PrintCurrentApple();
                keyPressed = Console.ReadKey(true);
                snake.RecognizeMovementKey(keyPressed.Key);
                snake.Move();
                snake.EatApple(apple);
            } while (!snake.IsDead(gameTable) && !snake.HasCrashedItself());
        }
    }
}
