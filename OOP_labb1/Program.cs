
using System;

namespace OOP_labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine("Cirkelns area:");
            Console.WriteLine(c1.getArea());
            Console.WriteLine("Cirkelns omkrets:");
            Console.WriteLine(c1.getCircumference());

            Console.WriteLine(" ");

            Circle c2 = new Circle(6);
            Console.WriteLine("Cirkelns area:");
            Console.WriteLine(c2.getArea());
            Console.WriteLine("Cirkelns omkrets:");
            Console.WriteLine(c2.getCircumference());

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

        public double getArea()
        {
            float area = _radie * _radie * _pi;
            return area;
            
        }

        public double getCircumference() //Extra utmaning omkrets
        {
            float diameter = _radie * 2;
            float circumference = diameter * _pi;
            return circumference;
        }

    }
    
}

