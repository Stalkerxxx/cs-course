using System;

namespace homeWork12
{
    class PhoneReminderItem : Reminderltem
    {
        public string PhoneNumber{ get; set; }
        public PhoneReminderItem(
            DateTimeOffset alarmDate,
            string alarmMessange,
            string phoneNumber
            )
            : base(alarmDate, alarmMessange)
        {
            PhoneNumber = phoneNumber;  
        }
        public override void WriteProperties()
        {
            Console.WriteLine($"PhoneReminderItem:" +
                $" \nThe alarm clock is set for: {AlarmDate}, {AlarmMessange}," +
                $" time to wake up:{TimeToAlarm.Days}:{TimeToAlarm.Hours}:{TimeToAlarm.Minutes}," +
                $" {IsOutdated} and phone number: {PhoneNumber}");
        }
    }
}
