using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_11_jan_18
{
    interface IRectangle
    {
        int A { get; set; }
        int B { get; set; }
    }
    interface ISquare
    {
        void Square(IRectangle rectangle);
    }
    abstract class Shape
    {
        public virtual int MyProperty { get; }
    }
    class Rectangle : Shape, ISquare, IRectangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public void Square(IRectangle rectangle)
        {
            Console.WriteLine(rectangle.A * rectangle.B);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.A = 15;
            rectangle.B = 16;
            
        }
    }
}
