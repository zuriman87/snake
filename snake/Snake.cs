using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Snake (Point tail, int lenght, Direction direction)
        {
            for (int i = 0; i < lenght; i++)
            {
                pList = new List<Point>();
                Point p = new Point (tail);
                p.Move(i, direction);
                pList.Add(p);

            }
        }
    }
}
