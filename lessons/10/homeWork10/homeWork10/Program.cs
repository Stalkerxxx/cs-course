using System;

namespace homeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            byte age = default;
            Person[] arrPerson = new Person[3];
            for (int i = 0; i < arrPerson.Length; i++)
            {
                arrPerson[i] = new Person
                {
                    NameUser = name,
                    AgeUser = age
                };
                arrPerson[i].Name();
                arrPerson[i].Age();
                Console.WriteLine(arrPerson[i].Discription);
            }
            Console.ReadKey();
        }
    }
}
