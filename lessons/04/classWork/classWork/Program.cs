using System;

namespace classWork
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of a: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Enter value of h: ");
            double h = double.Parse(Console.ReadLine());

            double faceArea = 3 * a * h;
            double pyramidSquare = 3.0 / 2.0 * a * (a * Math.Sqrt(3) + 2 * h);
            double H = Math.Sqrt(h * h - a * a / 12);
            double pyramidVolume = a * a / 2 * H;
                
            Console.WriteLine("Side face area: " + faceArea );
            Console.WriteLine("Side pyramid square: " + pyramidSquare );
            Console.WriteLine("Side pyramid volume: " + pyramidVolume );
        }
    }
}
