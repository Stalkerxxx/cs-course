using System;
using Calculator.Figure;
using Calculator.Operation;

namespace Calculator.Result
{
    class Program
    {
        static void Main(string[] args)
        {
            var circleRadius = 1.5;
            var circle = new Circle(circleRadius);
            var circlePerimeter = circle.Calculate(CircleOperation.Perimeter);
            var circleSquare = circle.Calculate(CircleOperation.Square);

            Console.WriteLine(
                $"For the circle with radius = {circleRadius}\n" +
                $"Perimeter = {circlePerimeter}\n" +
                $"Square = {circleSquare}"
                );

            var sideSquare = 2.0;
            var square = new Square(sideSquare);
            var squarePerimeter = square.Calculate(SquareOperation.Perimeter);
            var squareSquare = square.Calculate(SquareOperation.Square);

            Console.WriteLine(
                $"For the square with side = {sideSquare}\n" +
                $"Perimeter = {squarePerimeter}\n" +
                $"Square = {squareSquare}"
                );
        }
    }
}
