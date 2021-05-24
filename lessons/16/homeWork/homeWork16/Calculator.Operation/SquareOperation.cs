using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operation
{
    public class SquareOperation
    {
        public static double Perimeter(double side) => 4 * side;
        public static double Square(double side) => Math.Pow(side, 2);
    }
}
