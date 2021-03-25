using System;

namespace homeWork5
{
    /*Написать консольное приложение, которое спросит у пользователя тип фигуры (1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник),
     * затем спросит параметры фигуры:
     * 1.для круга - диаметр 
     * 2.для треугольника - длину стороны
     * 3.для прямоугольника - ширину и высоту
     * В качестве результата программа должна вывести площадь поверхности и длину периметра соответствующей фигуры.
     * Тип фигур должен быть объявлен в виде перечисления.Необходимо обработать все предсказуемые исключения.
     */
    class Program
    {
        [Flags]
        enum Shapes
        {
            Circle = 1,
            Triangle = 2,
            Rectangle = 3
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the shape type from the list: ");
            Console.WriteLine($"{Shapes.Circle} - 1 {Shapes.Triangle} - 2 {Shapes.Rectangle} - 3");
            Shapes numberShapes = default;
           
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    numberShapes = (Shapes)Enum.Parse(typeof (Shapes), Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Entered value not a number, give number");
                    //Console.WriteLine($"{ex.GetType()}: {ex.Message}");
                }
            }

            switch (numberShapes)
            {
                case Shapes.Circle:
                    Console.WriteLine("Circle: ");
                    Console.Write("Enter the diameter of the circle: ");
                    
                    double d = default;

                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            d = double.Parse(Console.ReadLine());

                            break;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Entered value not a number, give number");
                            //Console.WriteLine($"{ex.GetType()}: {ex.Message}");
                        }
                    }
                    
                    if (d < 0)
                    {
                        Console.WriteLine("The diameter of the circle cannot be less than 0");
                        break;
                    }

                    double circlePerimeter = Math.PI * d;
                    double circleArea = 1.0 / 4 * Math.PI * Math.Pow(d, 2);
                    Console.WriteLine($"The circumference = {Math.Round(circlePerimeter, 2)}");
                    Console.WriteLine($"The area of the circle = {Math.Round(circleArea, 2)}");
                    break;
                case Shapes.Triangle:
                    Console.WriteLine("Triangle");
                    Console.WriteLine("Enter the sides of the triangle:");
                    //double[] sides = new double [3]; // В качестве эксперимента ушел от объявления 3 переменных
                    //double sidesTriangle;
                    //for (int i = 0; i < sides.Length; i++)
                    //{
                    //    sidesTriangle = double.Parse(Console.ReadLine());
                    //    if (sides[0] > sides[1] + sides[2] && 
                    //        sides[1] > sides[0] + sides[2] &&
                    //        sides[2] > sides[0] + sides[1])
                    //    {
                    //        Console.WriteLine("The data does not match the definition of a triangle");
                    //    }

                    //    sides[i] = sidesTriangle;
                    //}

                    double a = default;
                    double b = default;
                    double c = default;

                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            a = double.Parse(Console.ReadLine());
                            b = double.Parse(Console.ReadLine());
                            c = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Entered value not a number, give number");
                            //Console.WriteLine($"{ex.GetType()}: {ex.Message}");
                        }
                    }

                    if (a < 0 || b < 0 || c < 0)
                    {
                        Console.WriteLine("The sides of a triangle cannot be less than 0");
                        break;
                    }

                    if (a >= b + c || b >= a + c || c >= a + b)
                    {
                        Console.WriteLine("The data does not match the definition of a triangle");
                        break;
                    }

                    double trianglePerimeter = a + b + c;
                    double halfMeter = trianglePerimeter / 2;
                    double triangleArea = Math.Sqrt(halfMeter * (halfMeter - a)*(halfMeter - b)*(halfMeter - c));// Исключение на отрицательный корень не требуется, т.к. в начале есть. 
                    Console.WriteLine($"The perimeter of the triangle = {trianglePerimeter}");
                    Console.WriteLine($"The area of the triangle = {triangleArea}");
                    break;
                case Shapes.Rectangle:
                    Console.WriteLine("Rectangle:");
                    Console.WriteLine("Enter the two sides of the rectangle:");
                    double aRectangle = default;
                    double bRectangle = default;

                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            aRectangle = double.Parse(Console.ReadLine());
                            bRectangle = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Entered value not a number, give number");
                            //Console.WriteLine($"{ex.GetType()}: {ex.Message}");
                        }
                    }

                    if (aRectangle < 0 || bRectangle < 0)
                    {
                        Console.WriteLine("The sides of a rectangle cannot be less than 0");
                        break;
                    }

                    double rectanglePerimeter = (aRectangle + bRectangle) * 2;
                    double rectangleArea = aRectangle * bRectangle;
                    Console.WriteLine($"The perimeter of the rectangle = {rectanglePerimeter}");
                    Console.WriteLine($"The area of the rectangle = {rectangleArea}");
                    break;
            }
        }
    }
}
