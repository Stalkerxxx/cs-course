using System;

namespace homeWork4
{
    class Program
    {
        [Flags]
        enum Colors : short
        {
            Black = 0b0000_0000_0000_0001, //1
            Blue = 0b0000_0000_0000_0001 << 1, //2
            Cyan = 0b0000_0000_0000_0001 << 2, //4
            Grey = 0b0000_0000_0000_0001 << 3, //8
            Green = 0b0000_0000_0000_0001 << 4, //16
            Magenta = 0b0000_0000_0000_0001 << 5, //32 
            Red = 0b0000_0000_0000_0001 << 6, //64
            White = 0b0000_0000_0000_0001 << 7,//128
            Yellow = 0b0000_0000_0000_0001 << 8 //256
        }
        static void Main(string[] args)
        {
            /*
             * Написать программу для добавления цветов заданной палитры в “избранное”.
             * Программа выводит список цветов с их порядковыми номерами и просит пользователя 
             * в цикле выбрать 4 цвета для добавления их в палитру “Избранное”.
             * Выбор производится путём введения порядковых номеров этих цветов.
             * После завершения ввода программа выводит список любимых цветов, а также отдельно список нелюбимых цветов.
            */
            Console.WriteLine($"Suggested color list: {Colors.Black} - 1 {Colors.Blue} - 2 {Colors.Cyan} - " +
                $"4 {Colors.Green} - 8 {Colors.Grey} - 16 {Colors.Magenta}" +
                $" - 32 {Colors.Red} - 64 {Colors.White} - 128 {Colors.Yellow} - 256");
            
            var sum1 = Colors.Black | Colors.Blue | Colors.Cyan | Colors.Green | Colors.Grey 
            | Colors.Magenta | Colors.Red | Colors.White | Colors.Yellow; 
            
            Console.WriteLine("Enter your favorite color number: ");
            int favoritColor1 = int.Parse(Console.ReadLine());
            int favoritColor2 = int.Parse(Console.ReadLine());  
            int favoritColor3 = int.Parse(Console.ReadLine());  
            int favoritColor4 = int.Parse(Console.ReadLine());
            int sum = favoritColor1 + favoritColor2 + favoritColor3 + favoritColor4;

            var favoritColors = (Colors)sum;
            Console.WriteLine($"List of favorite colors: {favoritColors}");
            Console.WriteLine($"List of disliked colors: {sum1 ^ favoritColors}");           
        }
    }   
}
