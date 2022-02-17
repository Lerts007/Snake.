using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        public static List<Point> snake = new List<Point>();
        Direction _direction;

        
        public Snake(Point tail, int lenght, Direction direction)
        {
            _direction = direction;

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                p.Draw();
                snake.Add(p);
            }
        }

        public void Move()
        {
            Point tail = snake.First();
            snake.Remove(tail);
            Point head = GetNextPoint();
            snake.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = snake.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public bool Eat(Point p)
        {
            Point pS = snake.Last();
            if (p == pS)
            {
                p._ch = pS._ch;
                pS = GetNextPoint();
                snake.Add(pS);
                return true;                
            }
            return false;
                

        }

        public void SnakeControl (ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow)
                _direction = Direction.UP;

            else if (key == ConsoleKey.DownArrow)
                _direction = Direction.DOWN;

            else if (key == ConsoleKey.LeftArrow)
                _direction = Direction.LEFT;

            else
                _direction = Direction.RIGHT;
        }
    }
}
