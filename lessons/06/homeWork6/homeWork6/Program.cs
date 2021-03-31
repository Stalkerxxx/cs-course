using System;

namespace homeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
           // Написать консольное приложение, которое запрашивает натуральное число и выводит количество четных цифр в нем.

            int num = default;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("Enter natural number: ");
                    num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        Console.WriteLine("Enter a positive value \nTry again");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entered value not a number, give number \nTry again");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The entered value exceeds the allowed value \nTry again");
                }
             
            }

            int num1 = num;
            int sum = 0;

            while (num1 > 0)
            {
                if (num1 % 2 == 0)
                {
                    sum++;
                }
                num1 /= 10;
            }
            Console.WriteLine($"The number {num} contains the following number of even digits: {sum}");
        }
    }
}
