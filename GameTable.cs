using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class GameTable
    {
        public int XLim { get; }
        public int YLim { get; }

        public GameTable(int x, int y)
        {
            XLim = x;
            YLim = y;
        }

        public void ShowGameTable()
        {
            for (int i = 0; i <= YLim; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Utilities.PrintChar(0, i, "*");
                Utilities.PrintChar(YLim, i, "*");
                Utilities.PrintChar(i, 0, "*");
                Utilities.PrintChar(i, XLim, "*");
                Console.ResetColor();
            }
        }
    }
}
