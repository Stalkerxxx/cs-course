using System;

namespace classWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 100)
            {
                Console.WriteLine("The age is too big");
                return;
            }

            var q = userAge / 10;
            var r = userAge % 10;

            if (q != 1 && r == 1)
            {
                Console.WriteLine($"{userAge} год");
            }
            else if (q != 1 && q >= 2 && r >= 2 && r < 5)
            {
                Console.WriteLine($"{userAge} года");
            }
            else
            {
                Console.WriteLine($"{userAge} лет");
            }

        }
    }
}
