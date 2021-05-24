using System;

namespace Calculator.Operation
{
    public class CircleOperation
    {
        public static double Perimeter(double radius) => 2 * radius * Math.PI;
        public static double Square(double radius) => Math.PI * Math.Pow(radius, 2);
    }
}
