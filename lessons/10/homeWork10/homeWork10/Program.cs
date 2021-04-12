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
                string name;
                byte age;
                while (true)
                {
                    Console.WriteLine("Enter the name of the user: ");
                    name = Console.ReadLine();

                    if (name == "" || name == null)
                    {
                        Console.WriteLine("You entered an empty string");
                        continue;
                    }
                    Console.WriteLine("Enter the age of the user:");
                    try
                    {
                        age = byte.Parse(Console.ReadLine());
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("You entered too many number \n Try again");
                        continue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You entered not a number \n Try again");
                        continue;
                    }
                    break;
                }

                arrPerson[i] = new Person
                {
                    Name = name,
                    Age = age
                };

                arrPerson[i].AgeFourYears();
                Console.WriteLine(arrPerson[i].Discription);
            }
            Console.ReadKey();
        }
    }
}
