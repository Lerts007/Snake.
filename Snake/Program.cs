using System;
using System.Windows;
using System.Drawing;
using System.Timers;

namespace Snake
{
    class Program
    {
        private static System.Timers.Timer aTimer;

        static void Main()
        {
            SetTimer();

            Wall wall = new Wall(119, 29, '#');

            Snakee snake = new Snakee();

            Console.ReadLine();
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
    
}