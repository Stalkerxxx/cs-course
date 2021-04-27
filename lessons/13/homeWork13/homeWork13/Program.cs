using System;

namespace homeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane1 = new Plane(10000, 12);
            plane1.WriteAllPropertise();

            Helicopter helicopter1 = new Helicopter(5000, 6);
            helicopter1.WriteAllPropertise();
        }
    }
}
