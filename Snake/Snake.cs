using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        private List<Point> snake = new List<Point>();
        public Snake(Point tail, int lenght, Direction direction)
        {
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                p.Draw();
                snake.Add(p);
            }
        }
    }
}
