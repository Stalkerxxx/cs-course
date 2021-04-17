using System;

namespace homeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Reminderltem firstSignal = new Reminderltem(
                new DateTimeOffset(2021, 04, 17, 20, 20, 34, TimeSpan.Zero),
                "You overslept the alarm clock!!!"
                );
            Reminderltem secondSignal = new Reminderltem(
                new DateTimeOffset(2021, 04, 19, 20, 20, 34, TimeSpan.Zero),
                "There is a time before the alarm clock"
                );
            firstSignal.WriteProperties();
            secondSignal.WriteProperties();
        }
    }
}
