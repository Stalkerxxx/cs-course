using System;

namespace homeWork4
{
    [Flags]
    enum Colors : short
    {
        Black = 0x0,
        Blue = 0x1 << 1,
        Cyan = 0x1 << 2,
        Grey = 0x1 << 3,
        Green = 0x1 << 4,
        Magenta = 0x1 << 5,
        Red = 0x1 << 6,
        White = 0x1 << 7,
        Yellow = 0x1 << 8
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
            for (int i = 0; i < 4; i++)
            {
                int favoriteColor = int.Parse(Console.ReadLine());
                if (favoriteColor == 1)
                {
                    var favoriteColor1 = Colors.Black;
                    Console.WriteLine(favoriteColor1 | favoriteColor1);
                }
                if (favoriteColor == 2)
                {
                    var favoriteColor2 = Colors.Blue;
                }
                if (favoriteColor == 3)
                {
                    var favoriteColor3 = Colors.Cyan;
                }
                if (favoriteColor == 4)
                {
                    var favoriteColor4 = Colors.Green;
                }
                if (favoriteColor == 5)
                {
                    var favoriteColor5 = Colors.Grey;
                }
                if (favoriteColor == 6)
                {
                    var favoriteColor6 = Colors.Magenta;
                }
                if (favoriteColor == 7)
                {
                    var favoriteColor7 = Colors.Red;
                }
                if (favoriteColor == 8)
                {
                    var favoriteColor8 = Colors.White;
                }
                if (favoriteColor == 9)
                {
                    var favoriteColor9 = Colors.Yellow;
                    
                }
                else 
                {
                    Console.WriteLine("This color is not in the list");
                }
               
            }
        }
    }   
}
