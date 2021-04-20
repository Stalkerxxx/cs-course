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
            base.WriteProperties();
            Console.WriteLine(
                $"PhoneReminderItem:" +
                $" {IsOutdated} and phone number: {PhoneNumber}"
                );
        }
    }
}
