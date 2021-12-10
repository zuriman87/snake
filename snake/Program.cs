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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7, 2, '&');
            p3.Draw();

            Point p4 = new Point(3, 7, '@');
            p4.Draw();

            HorizontalLines line1 = new HorizontalLines(4, 25, 8, '=');
            line1.Draw();

            Console.ReadLine();
        }

    }
}
