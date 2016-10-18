using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcNauticalMiles();
        }

        /// <summary>
        /// Write a program to receive values of latitude (L1,L2) and longitude (G1,G2), in degrees, 
        /// of two places on the Earth and output the distance D between them in nautical miles.
        /// The formula for distance in nautical miles is:
        /// D = 3963 * cos^-1(sin L1 sin L2 + cos L1 cos L2 * cos(G2 - G1));
        /// </summary>

        static void CalcNauticalMiles()
        {
            double L1, L2;
            double G1, G2;
            double D;

            Console.WriteLine("Please enter the latitudes in degrees of the two places you want to calculate the distance between");

            L1 = Convert.ToDouble(Console.ReadLine()) * 3.14 / 180;
            L2 = Convert.ToDouble(Console.ReadLine()) * 3.14 / 180;

            Console.WriteLine("Please enter the longitudes in degrees of the two places you want to calculate the distance between");

            G1 = Convert.ToDouble(Console.ReadLine()) * 3.14 / 180;
            G2 = Convert.ToDouble(Console.ReadLine()) * 3.14 / 180;

            D = 3963 * Math.Acos(Math.Sin(L1) * Math.Sin(L2) + Math.Cos(L1) * Math.Cos(L2) * Math.Cos(G2 - G1));

            Console.WriteLine("The distance between two points with the location ({0},{1}) and ({2},{3}) is {4} nautical miles.", L1, G1, L2, G2, D);
        }
    }
}
