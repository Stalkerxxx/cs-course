using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Select a mathematical operation:");
            string str1 = Console.ReadLine();

            switch (str1)
            {
                case "+":
                    Console.WriteLine("The result of addition:");
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("Subtraction result:");
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("Multiplication result:");
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("The result of dividing the first number by the second number:");
                    Console.WriteLine(num1 / num2);
                    Console.WriteLine("The result of dividing the second number by the first number:");
                    Console.WriteLine(num2 / num1);
                    break;
                case "%":
                    Console.WriteLine("Enter the number to divide by:");
                    int remainderAfterDivision = int.Parse(Console.ReadLine());
                    Console.WriteLine("The remainder of the division of the first number");
                    Console.WriteLine(num1 % remainderAfterDivision);
                    Console.WriteLine("The remainder of the division of the second number");
                    Console.WriteLine(num2 % remainderAfterDivision);
                    break;
                case "^":
                    Console.WriteLine("Enter degree of number:");
                    int degreeOfNumbers = int.Parse(Console.ReadLine());
                    Console.WriteLine("First number to the power of " + degreeOfNumbers);
                    Console.WriteLine(Math.Pow(num1, degreeOfNumbers));
                    Console.WriteLine("Second number to the power of " + degreeOfNumbers);
                    Console.WriteLine(Math.Pow(num2, degreeOfNumbers));
                    break;
            }
            
        }
    }
}
