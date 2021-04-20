using System;

namespace homeWork12
{
    class ChatReminderItem : Reminderltem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine($"ChatReminderItem:" +
                $" \n  Chat name: {ChatName}" +
                $" and account name: {AccountName}");
        }
        public ChatReminderItem(
            DateTimeOffset alarmDate,
            string alarmMessange,
            string chatName,
            string accountName
            ) 
            : base(alarmDate, alarmMessange)
        {
            ChatName = chatName;
            AccountName = accountName;
        }
    }
}
