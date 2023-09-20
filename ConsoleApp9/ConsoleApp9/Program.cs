using System;

namespace VectorLengthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, length;

            Console.WriteLine("Введите координату X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Z:");
            z = Convert.ToDouble(Console.ReadLine());

            length = Math.Sqrt(x * x + y * y + z * z); // Формула для вычисления длины вектора

            Console.WriteLine("Длина вектора: " + length);

            Console.ReadLine();
        }
    }
}   