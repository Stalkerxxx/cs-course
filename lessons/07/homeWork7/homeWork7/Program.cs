using System;

namespace homeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение, которое запрашивает строку и выводит количество слов, начинающихся на букву A
            //Программа должна спрашивать исходную строку до тех пор, пока пользователь не введёт хотя бы 2 слова.

            
            string[] arr;

            for (int i = 0; ; i++)
            {
                Console.Write("Enter a text consisting of at least 2 words: ");
                string str = Console.ReadLine();

                if (str == null)
                {
                    Console.Write("Enter a text consisting of at least 2 words: ");
                    continue;
                }

                arr = str.Split(' ', '\t', StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length == 0 || arr.Length == 1)
                {
                    Console.Write("Enter a text consisting of at least 2 words: ");
                    continue;
                }
                break;
            }

            int counter = default;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].StartsWith("A") || arr[i].StartsWith("a"))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
