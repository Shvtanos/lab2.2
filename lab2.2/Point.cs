using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    public class Point
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        // Конструктор по умолчанию
        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        // Конструктор копирования
        public Point(Point other)
        {
            x = other.x;
            y = other.y;
        }

        // Переопределение ToString() для удобного вывода объекта
        public override string ToString()
        {
            return $"Point({x}, {y})";
        }

        // Метод для вычисления расстояния от начала координат
        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // метод для обмена координат X и Y
        public void SwapCoordinates()
        {
            double temp = x;
            x = y;
            y = temp;
        }

        // Оператор уменьшения (decrement) для точки
        public static Point operator --(Point p)
        {
            return new Point(p.x - 1, p.y - 1);
        }

        // Метод вычитания двух точек
        public static Point Subtract(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p2.y);
        }

        // Метод вычисления расстояния между двумя точками
        public static double DistanceBetween(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        // Имплицитное приведение типа Point к int
        public static implicit operator int(Point p)
        {
            return (int)p.X;
        }

        // Эксплицитное приведение типа Point к double
        public static explicit operator double(Point p)
        {
            return (double)p.y; 
        }

        // Метод сложения точки с целым числом
        public static Point Add(Point p, int num)
        {
            return new Point(p.x + num, p.y);
        }

        // Метод сложения целого числа с точкой
        public static Point Add2(int num, Point p)
        {
            return new Point(p.x, p.y + num);
        }
    }
}