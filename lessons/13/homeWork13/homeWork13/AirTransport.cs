using System;

namespace homeWork13
{
    abstract class AirTransport
    {
        public int MaxHeight { get; protected set; }
        public int CurrentHeight { get; protected set; }
        public void TakeUpper(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (CurrentHeight + delta > MaxHeight)
            {
                CurrentHeight = MaxHeight;
            }
            else
            {
                CurrentHeight = delta + CurrentHeight;
            }
             CurrentHeight += delta;
        }
        public void TakeLower(int delta)
        {
            if (delta <= 0)
            {                  
                throw new ArgumentOutOfRangeException();
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
                throw new InvalidOperationException("Crash!");
            }
            CurrentHeight -= delta;
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
