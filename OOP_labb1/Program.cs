
using System;

namespace OOP_labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine("Cirkelns area:");
            c1.getArea();
            Console.WriteLine("Cirkelns omkrets:");
            c1.getCircumference();

            Console.WriteLine(" ");

            Circle c2 = new Circle(6);
            Console.WriteLine("Cirkelns area:");
            c2.getArea();
            Console.WriteLine("Cirkelns omkrets:");
            c2.getCircumference();

        }
    }

    public class Circle
    {

        public float _pi = 3.14f;
        public int _radie;

        public Circle(int r)
        {
            this._radie = r;
        }

        public void getArea()
        {
            float area = _radie * _radie * _pi;
            Console.WriteLine(area);
        }

        public void getCircumference() //Extra utmaning omkrets
        {
            float diameter = _radie * 2;
            float circumference = diameter * _pi;
            Console.WriteLine(circumference);
        }

    }
    
}

