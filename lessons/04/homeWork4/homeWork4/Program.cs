using System;

namespace homeWork4
{
    [Flags]
    enum Colors : short
    {
        Black = 1,
        Blue = 1 << 1,
        Cyan = 1 << 2,
        Grey = 1 << 3,
        Green = 1 << 4,
        Magenta = 1 << 5,
        Red = 1 << 6,
        White = 1 << 7,
        Yellow = 1 << 8
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Написать программу для добавления цветов заданной палитры в “избранное”.
             * Программа выводит список цветов с их порядковыми номерами и просит пользователя 
             * в цикле выбрать 4 цвета для добавления их в палитру “Избранное”.
             * Выбор производится путём введения порядковых номеров этих цветов.
             * После завершения ввода программа выводит список любимых цветов, а также отдельно список нелюбимых цветов.
            */
            Console.WriteLine($"List of colors:");
            Console.WriteLine( $"{Colors.Black} - 1");
            Console.WriteLine( $"{Colors.Blue} - 2");
            Console.WriteLine( $"{Colors.Cyan} - 3");
            Console.WriteLine( $"{Colors.Green} - 4");
            Console.WriteLine( $"{Colors.Grey} - 5");
            Console.WriteLine( $"{Colors.Magenta} - 6");
            Console.WriteLine( $"{Colors.Red} - 7");
            Console.WriteLine( $"{Colors.White} - 8");
            Console.WriteLine( $"{Colors.Yellow} - 9");
            Console.WriteLine("Enter the sequence numbers of the colors to add to your favorites: ");
            
            var favoriteColor = Enum.GetValues(typeof(Colors));

            for (int i = 0; i <= 4; i++)
            {
                
            }
        }
    }   
}
