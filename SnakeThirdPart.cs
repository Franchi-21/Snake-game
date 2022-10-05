using System.Drawing;
using System.Security.Cryptography;

namespace SnakeGame
{
    partial class Snake
    {
         public void EatApple(Apple apple)
         {
            if (Serpent.Any(s => s.X == apple.Location.X && s.Y == apple.Location.Y))
            {
                apple.GenerateNewLocation();
                Score += 150;
                Serpent.Add(new Location(Serpent.Last().X, Serpent.Last().Y - 1));
            }            
         }

         public bool IsDead(GameTable table)
         {
            return Serpent.Any(s => s.X < 0 || s.X > table.XLim || s.Y < 0 || s.Y > table.YLim);
         }

         public bool HasCrashedItself()
         {
            int xFirst = Serpent.First().X;
            int yFirst = Serpent.First().Y;
            List<Location> previousToTheFirst = new(0);
            previousToTheFirst.AddRange(Serpent);
            previousToTheFirst.Remove(previousToTheFirst.First());
            return previousToTheFirst.Any(p => p.X == xFirst && p.Y == yFirst);
         }
    }
}
