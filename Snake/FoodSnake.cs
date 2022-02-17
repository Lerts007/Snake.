using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodSnake
    {
        private static Random r = new Random();
        public Point p = null;
        private int _x;
        private int _y;
        private char _ch;

        public FoodSnake()
        {
            _x = r.Next(1, 119);
            _y = r.Next(1, 24);
            _ch = '$';
            p = new Point(_x, _y, _ch);
            p.Draw();
        }

        public void Draw()
        {
            _x = r.Next(1, 119);
            _y = r.Next(1, 24);
            p = new Point(_x, _y, _ch);
            p.Draw();
        }
    }
}
