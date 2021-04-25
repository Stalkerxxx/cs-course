using System;

namespace homeWork13
{
    class Helicopter : AirTransport
    {
        public byte BladesCount { get; private set; }
        public Helicopter(int maxHeight, byte bladesCount)
        {
            CurrentHeight = 0;
            MaxHeight = maxHeight;
            BladesCount = bladesCount;
                Console.WriteLine("It's a helicopter, welcome aboard");
        }

        public override void WriteAllPropertise() 
        {
            Console.WriteLine("Propertise of Helicopter:");
            base.WriteAllPropertise2();
            Console.WriteLine($"EnginesCount: {BladesCount}");
        }

    }
}
