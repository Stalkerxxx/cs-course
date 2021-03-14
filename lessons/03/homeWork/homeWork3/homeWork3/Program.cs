using System;

namespace homeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Написать консольное приложение, запрашивающее у пользователя имена трех человек. 
             *Затем также запрашивающее возраст этих людей. Затем программа должна вывести на экран информацию
             *о людях и их возрастах через 4 года. Задание должно быть сделано с использованием массивов и циклов.
            */

            string[] listOfUsers = new string[3];
            int[] userAge = new int[3];

            Console.WriteLine("Enter the names of the three users:");
            for (int i = 0; i < listOfUsers.Length; i++)
            {
                listOfUsers[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the age of the users:");
            for (int i = 0; i < userAge.Length; i++)
            {
                userAge[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("User age after four years:");
            for (int i = 0; i < userAge.Length; i++)
            {
                userAge[i] = userAge[i] + 4;
                Console.WriteLine(listOfUsers[i] + " — " + userAge[i]);
            }
        }
    }
}
