using System;
namespace OOPS
{
    interface IShape
    {
        double CalculateArea();
        void Display();
    }
    class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public void Display()
        {
            Console.WriteLine("Circle with radius: " + radius);
        }
    }
    class Square : IShape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public double CalculateArea()
        {
            return side * side;
        }
        public void Display()
        {
            Console.WriteLine("Square with side: " + side);
        }
    }
    class Triangle : IShape
    {
        private double baseLength;
        private double height;
        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
        public void Display()
        {
            Console.WriteLine("Triangle with base: " + baseLength + " and height: " + height);
        }
    }
}
