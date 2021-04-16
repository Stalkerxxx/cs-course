using System;

namespace homeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Reminderltem firstSignal = new Reminderltem(
                new DateTimeOffset(2021, 04, 17, 20, 20, 34, TimeSpan.Zero),
                "WAKE UP"
                );
           
            Console.WriteLine(firstSignal.WriteProperties);
            
        }
    }
}
