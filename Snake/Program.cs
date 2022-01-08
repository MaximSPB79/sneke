using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

           Console.ReadLine();
        }
    }
}
