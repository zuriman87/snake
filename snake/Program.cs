using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLines lineTop = new HorizontalLines(0, 79, 0, '+');
            lineTop.Drow();
            HorizontalLines lineBot = new HorizontalLines(0, 79, 24, '+');
            lineBot.Drow();
            VerticalLine lineRight = new VerticalLine(78, 1, 24, '+');
            lineRight.Drow();
            VerticalLine lineLeft = new VerticalLine(0, 1, 24, '+');
            lineLeft.Drow();

            Point p = new Point(4, 5, '=');

            Snake snake = new Snake (p, 5, Direction.RIGHT);

            
            
            Console.ReadLine();
        }

    }
}
