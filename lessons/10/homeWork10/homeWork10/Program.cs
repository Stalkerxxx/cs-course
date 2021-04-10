using System;

namespace homeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arrPerson = new Person[3];
            for (int i = 0; i < arrPerson.Length; i++)
            {
                Console.WriteLine("Enter the name of the user: ");
                string name = Console.ReadLine();
                if (name == "" || name == null)
                {
                    Console.WriteLine("You entered an empty string");
                    break;
                }
                Console.WriteLine("Enter the age of the user:");
                byte age = byte.Parse(Console.ReadLine());
                arrPerson[i] = new Person
                {
                    Name = name,
                    Age = age
                };

                Console.WriteLine(arrPerson[i].Discription);
            }
            Console.ReadKey();
        }
    }
}
