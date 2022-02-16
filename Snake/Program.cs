using System;
using System.Windows;
using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main()
        {

            Wall wall = new Wall(119, 29, '#');

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                        snake._direction = Direction.UP;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake._direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.LeftArrow)
                        snake._direction = Direction.LEFT;
                    else
                        snake._direction = Direction.RIGHT;
                }

                snake.Move();
                Thread.Sleep(300);
            }
        }
    }
    
}