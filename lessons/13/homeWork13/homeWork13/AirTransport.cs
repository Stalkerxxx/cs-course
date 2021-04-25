using System;

namespace homeWork13
{
    abstract class AirTransport
    {
        public int MaxHeight { get; protected set; }
        public int CurrentHeight { get; protected set; }
        public void TakeUpper(int delta)
        {
            CurrentHeight += delta;
            if (delta <= 0)
            {
                try
                {

                }
                catch (ArgumentOutOfRangeException)
                {
                    throw;
                }
            }
            if (CurrentHeight + delta > MaxHeight)
            {
                CurrentHeight = MaxHeight;
            }
            else
            {
                CurrentHeight = delta + CurrentHeight;
            }
        }
        public void TakeLower(int delta)
        {
            CurrentHeight -= delta;
            if (delta <= 0)
            {
                try
                {

                }
                catch (ArgumentOutOfRangeException)
                {
                    throw;
                }

            }
            if (CurrentHeight - delta > 0)
            {
                CurrentHeight -= delta;
            }
            if (CurrentHeight - delta == 0)
            {
                CurrentHeight = 0;
            }
            if (delta <= 0)
            {
                try
                {

                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Crash!");
                    throw;
                }
            }
        }
        public abstract void WriteAllPropertise();
        public virtual void WriteAllPropertise2() 
        {
            Console.WriteLine(
                $"CurrentHeight: {CurrentHeight}\n" +
                $"MaxHeight: {MaxHeight}"
                );
        }
    }
}
