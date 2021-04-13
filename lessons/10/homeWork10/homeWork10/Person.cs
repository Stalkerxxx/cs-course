using System;
namespace homeWork10
{
    class Person 
    {
        public string NameUser { get; set; }
        public byte AgeUser { get; set; }

        public string Name()
        {
            
            while (true)
            {
                Console.WriteLine("Enter the name of the user: ");
                NameUser = Console.ReadLine();
                if (NameUser == "" || NameUser == null)
                {
                    Console.WriteLine("You entered an empty string");
                    continue;
                }
                break;
            }
            return NameUser;
        }
        public byte Age()
        {
            while (true)
            {
                Console.WriteLine("Enter the age of the user:");
                try
                {
                    AgeUser = byte.Parse(Console.ReadLine());
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
            return AgeUser;
        }
        public byte AgeFourYears => AgeUser = (byte)(AgeUser + 4);
        public string Discription =>
            $"{NameUser} will be born in four years: {AgeFourYears}";

    }
}
