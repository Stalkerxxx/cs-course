using System;

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic shit = "100";
            shit = 100;
            Console.WriteLine(shit * shit);

            object str = "I love C#!!!";
            Console.WriteLine(((string)str).Length);

            var i1 = 100;
            var str1 = " This is a string ";
            var d = 10.0;
            var availability = 13413726.23m;
            Console.WriteLine(i1 + str1 + d + availability);

            string[] array = new string [4];
            for (int i = 0; i < array.Length; i++)
            {
               array[i] = Console.ReadLine();
            }

            ConsoleKeyInfo cki1 = Console.ReadKey();
            Console.WriteLine(cki1.Key.ToString());

            //инторпалированные строки
            var a = 1;
            var b = 2;
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
