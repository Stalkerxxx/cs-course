using System;

namespace homeWork12
{
    class Reminderltem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessange { get; set; }
        public TimeSpan TimeToAlarm =>
            DateTimeOffset.UtcNow.Subtract(AlarmDate);
        public bool IsOutdated =>
            TimeToAlarm >= TimeSpan.Zero;

        public virtual void WriteProperties()
        {
            Console.WriteLine($"Reminderltem:" +
                $" \nThe alarm clock is set for: {AlarmDate}, {AlarmMessange}," +
                $" time to wake up:{TimeToAlarm.Days}:{TimeToAlarm.Hours}:{TimeToAlarm.Minutes}," +
                $" {IsOutdated}");
        }

        public Reminderltem(
            DateTimeOffset alarmDate,
            string alarmMessange
            )
        {
            AlarmDate = alarmDate;
            AlarmMessange = alarmMessange;
        }
    }
}