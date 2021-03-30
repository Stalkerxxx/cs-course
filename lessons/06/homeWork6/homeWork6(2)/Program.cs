using System;

namespace homeWork6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение, которое запрашивает:
            //1) сумму первоначального взноса,
            //2) ежедневный процент дохода и желаемую сумму накопления. 
            //Программа должна вывести номер дня, когда накопление впервые превысит желаемое.

            int firstInstallment = default;
            double dailyPercentage = default;
            int desiredAmount = default;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("Enter the amount of the initial payment in rubles: ");
                    firstInstallment = int.Parse(Console.ReadLine());

                    for (int j = 0; j < 10; j++)
                    {
                        if (firstInstallment < 0)
                        {
                            Console.WriteLine("Enter a positive value \nTry again");
                            Console.Write("Enter the amount of the initial payment in rubles: ");
                            firstInstallment = int.Parse(Console.ReadLine());
                        }
                    }

                    /////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter the daily percentage of income as a decimal fraction (1% = 0,01): ");
                    dailyPercentage = Math.Round(double.Parse(Console.ReadLine()), 2);

                    for (int j = 0; j < 10; j++)
                    {
                        if (dailyPercentage < 0 || dailyPercentage > 1)
                        {
                            Console.WriteLine("Enter a positive value \nTry again");
                            Console.Write("Enter the daily percentage of income as a decimal fraction (1% = 0,01):  ");
                            dailyPercentage = double.Parse(Console.ReadLine());
                        }
                    }

                    /////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter the desired amount of savings in rubles: ");
                    desiredAmount = int.Parse(Console.ReadLine());

                    for (int j = 0; j < 10; j++)
                    {
                        if (desiredAmount < 0)
                        {
                            Console.WriteLine("Enter a positive value \nTry again");
                            Console.Write("Enter the desired amount of savings in rubles: ");
                            desiredAmount = int.Parse(Console.ReadLine());
                        }
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entered value not a number, give number \nTry again");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The entered value exceeds the allowed value \nTry again");
                }
            }
           
            double c = firstInstallment * dailyPercentage;
            double numberOfDays = (desiredAmount - firstInstallment) / c;

            Console.WriteLine($"The required number of days to accumulate the desired amount: {Math.Round(numberOfDays, 2)}");
        }
    }
}
