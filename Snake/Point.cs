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

        public Point(Point a) 
        {
            _x = a._x;
            _y = a._y;
            _ch = a._ch;
        }
        public Point(int x, int y, char ch)
        {
            _x = x;
            _y = y;
            _ch = ch;
        }

        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                _x += offset;
            if(direction == Direction.LEFT)
                _x -= offset;
            if(direction == Direction.UP)
                _y -= offset;
            if(direction == Direction.DOWN)
                _y += offset;
        }

        public void Draw()
        {
            DrawPoint(_ch);
        }

        public void Clear()
        {
            DrawPoint(' ');
        }

        public void DrawPoint(char ch)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(ch);
        }
    }
}
