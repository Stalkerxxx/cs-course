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
            bool letters = default;

            for (int k = 0; ; k++)
            {
                Console.Write("Enter a string containing printable characters: ");
                var str = Console.ReadLine();
                arrWords = str.Split(' ', '\t', StringSplitOptions.RemoveEmptyEntries);

                if (arrWords.Length == 0)
                {
                    Console.WriteLine("You entered invalid string characters\nTry again");
                    continue;
                }
                
                if (letters == false)
                {
                    for (int i = 0; i < arrWords.Length; i++)
                    {

                        for (int j = 0; j < arrWords[i].Length; j++)
                        {
                            arrLetters = arrWords[i].ToCharArray();
                            letters = char.IsLetter(arrLetters[j]);
                            Array.Reverse(arrLetters);
                            strReverse = string.Join("", arrLetters);
                        }

                        if (letters == false)
                        {
                            Console.WriteLine("You entered invalid string characters\nTry again");
                            continue;
                        }
                        Console.Write($"{strReverse.ToLower()} ");
                        break;
                    }
                    continue;
                }
                
                break;
                
            }
           
           // Console.Write("You will get the expression: ");

            
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
