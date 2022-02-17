using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Wall
    {
        public List<Point> Walls = new List<Point>();

        public Wall(int x, int y, char ch)
        {
            HorizontalLine(x, 0, ch);
            HorizontalLine(x, y, ch);
            VerticalLine(0, y, ch);
            VerticalLine(x, y, ch);
        }

        private void HorizontalLine(int x, int y, char ch)
        {
            for (int i = 0; i <= x; i++)
            {
                Point p = new Point(i, y, ch);
                p.Draw();
                Walls.Add(p);
            }
        }

        private void VerticalLine(int x, int y, char ch)
        {
            for (int i = 0; i <= y; i++)
            {
                Point p = new Point(x, i, ch);
                p.Draw();
                Walls.Add(p);
            }
        }
    }
}
