using System;

namespace homeWork7_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение, которое запрашивает строку, а затем выводит все буквы приведенные к нижнему регистру в обратном порядке.
            //Программа должна спрашивать исходную строку до тех пор, пока пользователь не введет строку, содержащую печатные символы.

            string[] arrWords;
            Char[] arrLetters;
            string strReverse = default;

            for (int i = 0; ; i++)
            {
                Console.Write("Enter a string containing printable characters: ");
                var str = Console.ReadLine();
                arrWords = str.Split(' ', '\t', StringSplitOptions.RemoveEmptyEntries);

                if (arrWords.Length == 0)
                {
                    Console.WriteLine("You entered invalid string characters\nTry again");
                    continue;
                }
                break;
            }
           
            Console.Write("You will get the expression: ");

            for (int i = 0; i < arrWords.Length; i++)
            {
                for (int j = 0; j < arrWords[i].Length; j++)
                {
                    arrLetters = arrWords[i].ToCharArray();
                    Array.Reverse(arrLetters);
                    strReverse = string.Join("", arrLetters);
                }
                Console.Write($"{strReverse.ToLower()} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
