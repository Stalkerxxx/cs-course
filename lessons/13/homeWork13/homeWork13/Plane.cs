using System;

namespace homeWork13
{
    class Plane : AirTransport
    {
        public byte EnginesCount { get; private set; }
        public Plane(int maxHeight, byte enginesCount)
        {
            CurrentHeight = 0;
            MaxHeight = maxHeight;
            EnginesCount = enginesCount;
            Console.WriteLine("It's a plane, welcome aboard");
        }
        public override void WriteAllPropertise()
        {
            Console.WriteLine("Propertise of Helicopter:");
            base.WriteAllPropertise2();
            Console.WriteLine($"EnginesCount: {EnginesCount}\n");
        }
    }
}
