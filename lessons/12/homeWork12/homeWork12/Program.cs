using System;
using System.Collections.Generic;

namespace homeWork12
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Создать лист объектов базового типа инициализированный как минимум 3-мя объектами разных типов.
            //Вывести на экран их свойства WriteProperties().

            List<Reminderltem> reminderltems = new List<Reminderltem>
            {
                new Reminderltem(
                    new DateTimeOffset(
                        2021, 04, 17, 20, 20, 34,
                        TimeSpan.Zero
                        ),
                    "You overslept the alarm clock!!!"
                    ),
                new PhoneReminderItem(
                new DateTimeOffset(
                    2021, 04, 17, 20, 20, 34,
                    TimeSpan.Zero
                    ),
                "You overslept the alarm clock!!!",
                "+7(925)874-20-21"
                ),
                new ChatReminderItem(
                    new DateTimeOffset(
                        2021, 04, 17, 20, 20, 34, 
                        TimeSpan.Zero
                        ),
                    "You overslept the alarm clock!!!",
                    "You don't have to go to work today",
                    "Nikolay"
                    )
            };

            foreach (Reminderltem reminderltem in reminderltems)
            {
                reminderltem.WriteProperties();
            }
        }
    }
}
