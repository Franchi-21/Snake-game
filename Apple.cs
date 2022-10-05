using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Apple
    {
        public Location Location { get; private set; }
        private Random newLocation;
        
        public Apple()
        {           
            newLocation = new Random();
            Location = new Location(15, 10);
        }

        public void PrintCurrentApple()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Utilities.PrintChar(Location.X, Location.Y, "x");
            Console.ResetColor();
        } 

        public void GenerateNewLocation() => Location = new Location(newLocation.Next(1, 20), newLocation.Next(1, 20));

    }
}
