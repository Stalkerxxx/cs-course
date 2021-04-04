using System;
using System.Text;

namespace homeWork7_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение, которое запрашивает строку, а затем выводит все буквы приведенные к нижнему регистру в обратном порядке.
            //Программа должна спрашивать исходную строку до тех пор, пока пользователь не введет строку, содержащую печатные символы.

            string[] arrWords;
            StringBuilder strReverse = default;
            


            for (int k = 0; ; k++)
            {
                Console.Write("Enter a string containing printable characters: ");
                var str = Console.ReadLine();
                if (str == null)
                {
                    Console.Write("Enter a string containing printable characters: ");
                    continue;
                }

                arrWords = str.Split(' ', '\t', StringSplitOptions.RemoveEmptyEntries);
                
                if (arrWords.Length == 0)
                {
                    Console.WriteLine("You entered invalid string characters\nTry again");
                    continue;
                }

                for (int i = 0; i < arrWords.Length; i++)
                {
                    for (int j = 0; j < arrWords[i].Length; j++)
                    {
                        Array.Reverse(arrWords);
                        char letters2 = char.Parse(arrWords[j]);
                        strReverse = strReverse.Append(letters2);
                    }

                    if (char.IsLetter(char.Parse(arrWords[i])) == false)
                    {
                        Console.WriteLine("You entered invalid string characters\nTry again");
                        continue;
                    }
                    Console.Write($"{strReverse.ToString().ToLower()} ");
                    break;
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
