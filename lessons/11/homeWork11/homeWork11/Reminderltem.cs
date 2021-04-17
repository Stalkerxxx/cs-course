using System;

namespace homeWork11
{
    class Reminderltem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessange{ get; set; }
        public TimeSpan TimeToAlarm => 
            DateTimeOffset.UtcNow.Subtract(AlarmDate);
        public bool IsOutdated =>
            TimeToAlarm >= TimeSpan.Zero;
        
        public void WriteProperties() 
        {
            Console.WriteLine($"The alarm clock is set for: {AlarmDate}, {AlarmMessange}," +
            $" time to wake up:{TimeToAlarm.Days}:{TimeToAlarm.Hours}:{TimeToAlarm.Minutes}," +
            $" {IsOutdated}");
        }

        public Reminderltem(DateTimeOffset alarmDate, string alarmMessange)
        {
            AlarmDate = alarmDate;
            AlarmMessange = alarmMessange;
        }
    }
}
