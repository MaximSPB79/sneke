using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine dounLine = new HorizontalLine(0, 78, 24, '+');
            VLine leftLine = new VLine (0,24,0,'+');
            VLine rightLine = new VLine(0,24,78,'+');
            upLine.Drow();
            dounLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            

            while (true)
            {
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow) snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow) snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.UpArrow) snake.direction = Direction.UP;
                    else if (key.Key == ConsoleKey.DownArrow) snake.direction = Direction.DOWN;
                }
               Thread.Sleep(100);
                snake.Move();
            }            
         
        }
    }
}
