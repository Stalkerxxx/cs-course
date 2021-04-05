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

            
            bool str1 = default;
            StringBuilder constructorLetters = new StringBuilder();

            while (true)
            {
                Console.WriteLine("Введите строку: ");
                var str = Console.ReadLine();
                var arrWords = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (str == null || str.Length == 0)
                {
                    Console.WriteLine("Вы ввели пустую строку попробуйте еще раз");
                    continue;
                }

                for (int i = 0; i < arrWords.Length; i++)
                {
                    for (int j = arrWords[i].Length - 1; j >= 0; j--)
                    {
                        str1 = char.IsLetter(arrWords[i][j]);
                        char str2 = arrWords[i][j];
                        constructorLetters.Append(str2);
                    }
                }
                if (str1 == false)
                {
                    Console.WriteLine("Введите печатные символы");
                    continue;
                }
                Console.WriteLine(constructorLetters.ToString().ToLower());
                break;
            }
        }    
    }
}
