using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BycicleRace
{
    class Program
    {
        static double CalculateMeetingPoint(double S, double A, double B)
        {
            return A / (A + B) * S;
        }
        static void Main()
        {
            Console.WriteLine("Введите расстояние между городами:");
            if (!double.TryParse(Console.ReadLine(), out double S))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.WriteLine("Введите скорость первого велосипедиста:");
            if (!double.TryParse(Console.ReadLine(), out double A))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.WriteLine("Введите скорость второго велосипедиста:");
            if (!double.TryParse(Console.ReadLine(), out double B))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.WriteLine("Место встречи: " + CalculateMeetingPoint(S, A, B).ToString("0.0000000") + "-й километр.");
        }
    }
}
