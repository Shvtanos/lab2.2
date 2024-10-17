using lab2._2;

using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаем экземпляр класса с конструктором по умолчанию
        Console.WriteLine("Тестирование конструкторов:");
        Point p1 = new Point();
        Console.WriteLine($"Создан объект p1: {p1}");
        Console.WriteLine($"Расстояние от начала координат до p1: {p1.DistanceToOrigin()}");

        // Создаем экземпляр класса с конструктором копирования
        Console.WriteLine("\nТестирование конструктора копирования:");
        Point p2 = new Point(p1);
        Console.WriteLine($"Создан объект p2, копирующий p1: {p2}");
        Console.WriteLine($"Расстояние от начала координат до p2: {p2.DistanceToOrigin()}");

        // Тест унарных операций
        Console.WriteLine("\nТест унарных операций:");
        Point p3 = --p1;
        Console.WriteLine($"p1 после уменьшения: {p1}");
        Console.WriteLine($"Создан объект p3, после уменьшения координат на 1: {p3}");

        // Тест операции приведения типа int
        Console.WriteLine($"\nПриведение p1 к типу int: {(int)p1}");

        // Тест операции приведения типа double
        Console.WriteLine($"\nПриведение p1 к типу double: {((double)p1)}");

        // Тест бинарных операций
        Console.WriteLine("\nТест бинарных операций:");
        Point p5 = Point.Add(p1, 5);
        Console.WriteLine($"p1.x + 5: {p5}");
        Point p52 = Point.Add2(5, p1);
        Console.WriteLine($"p1.y + 5: {p52}");
        //int num = 5 + (int)p1;
        //Console.WriteLine($"5 + p1: {num}");
        double distance = Point.DistanceBetween(p1, p2);
        Console.WriteLine($"Расстояние между p1 и p2: {distance}");

        // Тестирование ввода данных с проверкой на дурака
        Console.WriteLine("\nТестирование ввода данных с проверкой на дурака:");
        try
        {
            Console.Write("Введите координату X: ");
            double x = GetDoubleInput("");
            Console.Write("Введите координату Y: ");
            double y = GetDoubleInput("");

            Point p6 = new Point(x, y);
            Console.WriteLine($"Создан новый объект p6: {p6}");
            Console.WriteLine($"Расстояние от начала координат до p6: {p6.DistanceToOrigin()}");

            Console.Write("Введите число для уменьшения X: ");
            int numToSubtract = Convert.ToInt32(GetDoubleInput(""));
            Point p7 = Point.Subtract(p6, new Point(numToSubtract, p6.Y));
            Console.WriteLine($"Создан новый объект р7 - p6 после уменьшения X: {p7}");

            // Тест метода SwapCoordinates()
            Console.WriteLine("\nТест метода обмена координат:");
            p6.SwapCoordinates();
            Console.WriteLine($"p6 после обмена координат: {p6}");
            Console.WriteLine($"Новая точка после обмена: {new Point(p6.X, p6.Y)}");

            // Тест оператора уменьшения (decrement)
            Console.WriteLine($"\nТест оператора уменьшения (--):");
            Point p8 = --p6;
            Console.WriteLine($"p6 после уменьшения: {p6}");
            Console.WriteLine($"p8 после уменьшения: {p8}");

            // Тест метода Add()
            Console.WriteLine($"\nТест метода Add(). Введите число для добавления к координатам:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Point p9 = Point.Add(p6, a);
            Console.WriteLine($"p6.x + {a}: {p9}");
            Point p92 = Point.Add2(a, p6);
            Console.WriteLine($"p6.y + {a}: {p92}");

            // Тест метода DistanceBetween()
            Console.WriteLine($"\nТест метода DistanceBetween():");
            double Distance = Point.DistanceBetween(p6, p7);
            Console.WriteLine($"Расстояние между p6 и p7: {Distance}");

            // Тест приведения типов
            Console.WriteLine($"\nПриведение p6 к типу int: {(int)p6}");
            Console.WriteLine($"\nПриведение p6 к типу double: {((double)p6):F2}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }

    static double GetDoubleInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().Trim();

            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }
    }
}
