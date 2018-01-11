using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    interface IPoint
    {
        int x { get; set; }
        int y { get; set; }
    }
    interface ICoordinateQuarter
    {
        void GetQuarter(IPoint point);
    }
    class Point : IPoint, ICoordinateQuarter
    {
        public int x { get; set; }

        public int y { get; set; }

        public void GetQuarter(IPoint point)
        {
            if (point.x >= Console.WindowWidth / 2 && point.y >= Console.WindowHeight / 2)
                Console.WriteLine("Top Right Quarter (2)");
            else if (point.x <= Console.WindowWidth / 2 && point.y >= Console.WindowHeight / 2)
                Console.WriteLine("Top Left Quarter (1)");
            else if (point.x <= Console.WindowWidth / 2 && point.y <= Console.WindowHeight / 2)
                Console.WriteLine("Bottom Left Quarter (3)");
            else if (point.x >= Console.WindowWidth / 2 && point.y <= Console.WindowHeight / 2)
                Console.WriteLine("Bottom Right Quarter (4)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Point point = new Point();
            point.x = rand.Next(0, Console.WindowWidth);
            point.y = rand.Next(0, Console.WindowHeight);
            point.GetQuarter(point);
        }
    }
}
