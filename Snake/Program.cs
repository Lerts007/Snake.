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

            Console.ReadLine();
        }
    }
    
}