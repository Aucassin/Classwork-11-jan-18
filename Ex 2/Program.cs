using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    interface IGetPeak
    {
        int GetPeak { get; }
    }
    interface IGetSquare
    {
        double GetSquare();
    }
    abstract class Figure
    {
        public abstract double GetSquare();
    }
    class Rectangle : Figure, IGetSquare, IGetPeak
    {
        public int a { get; set; }
        public int b { get; set; }

        public int GetPeak
        {
            get
            {
                return 4;
            }
        }

        public override double GetSquare()
        {
            return a * b;
        }
    }
    class Circle : Figure, IGetSquare
    {
        public int R { get; set; }
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
    class Triangle : IGetPeak
    {
        public int GetPeak
        {
            get
            {
                return 3;
            }
        }
    }
    class Rhombus : IGetPeak
    {
        public int GetPeak
        {
            get
            {
                return 4;
            }
        }
    }
    static void GetCountOfPeaks(IGetPeak getPeak)
    {
        Console.WriteLine(getPeak.GetPeak);
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
