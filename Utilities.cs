using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum MovKeys { NO_KEY_PRESSED, UP, DOWN, LEFT, RIGHT }
    public static class Utilities
    {
        public static void PrintChar(int x, int y, string c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
