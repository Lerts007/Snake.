using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int _x;
        public int _y;
        public char _ch;

        public Point() { }
        public Point(int x, int y, char ch)
        {
            _x = x;
            _y = y;
            _ch = ch;
        }

        public void Draw()
        {
            DrawPoint(_ch);
        }
        public void Remove()
        {
            DrawPoint(' ');
        }

        private void DrawPoint (char ch)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(ch);
        }
    }
}
