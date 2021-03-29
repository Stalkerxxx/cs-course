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

            for (int i = 0; i < 10; i++)
            {
                if (num < 0)
                {
                    Console.WriteLine("Enter a positive value");
                    num = int.Parse(Console.ReadLine());
                }
            }


            string str = num.ToString();
            int[] arr = new int[str.Length];
            int sum = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = int.Parse(str[j].ToString());

                if (arr[j] % 2 == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"The number {num} contains the following number of even digits: {sum}");
        }
    }
}
