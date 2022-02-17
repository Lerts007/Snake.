﻿using System;
using System.Windows;
using System.Linq;
using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(120, 26);
            Console.WindowHeight = 26;
            Console.WindowWidth = 120;

            //Создание стены
            Wall wall = new Wall(119, 25, '#');

            //Создание еды
            FoodSnake food = new FoodSnake();

            //Создание змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            //Сама игра
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeControl(key.Key);
                }
                snake.Move();
                if (snake.Eat(food.p))
                    food.Draw();
                Thread.Sleep(300);
            }
        }
    }
}