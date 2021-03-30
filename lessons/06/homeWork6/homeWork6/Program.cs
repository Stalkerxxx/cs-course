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
                    for (int j = 0; j < 10; j++)
                    {
                        if (num < 0)
                        {
                            Console.WriteLine("Enter a positive value \nTry again");
                            num = int.Parse(Console.ReadLine());
                        }
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

            for (int i = 0; i < num1;)
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
