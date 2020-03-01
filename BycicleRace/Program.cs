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
            Console.WriteLine("Enter the distance between two cities:");
            if (!double.TryParse(Console.ReadLine(), out double S))
            {
                Console.WriteLine("Incorrect input.");
                return;
            }

            Console.WriteLine("Enter the speed of the first bicyclist:");
            if (!double.TryParse(Console.ReadLine(), out double A))
            {
                Console.WriteLine("Incorrect input.");
                return;
            }

            Console.WriteLine("Enter the speed of the second bicyclist:");
            if (!double.TryParse(Console.ReadLine(), out double B))
            {
                Console.WriteLine("Incorrect input.");
                return;
            }

            Console.WriteLine("Meeting point: " + CalculateMeetingPoint(S, A, B).ToString("0.0000000") + "km.");
        }
    }
}
