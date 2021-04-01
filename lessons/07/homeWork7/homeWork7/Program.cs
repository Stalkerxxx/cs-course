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
                arr = str.Split(' ', '\t' , StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length == 0 || arr.Length == 1)
                {
                    continue;
                }
                break;
            }

            int counter = default;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].StartsWith("A"))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
