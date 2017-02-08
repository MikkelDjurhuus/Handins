using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01312017_Triangles
{
    class Program
    {
        static bool ValidateTriangle(List<uint> lenghts)
        {
            lenghts.Sort();
            if (lenghts[0] < lenghts[1] + lenghts[2])
            {
                return true;
            }
            return false;
        }

        static uint GetSide()
        {
            while (true)
            {
                Console.WriteLine("Write a number: ");

                uint result;
                if (uint.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Not a number, try again..");
                }
            }
        }

        static List<uint> GetTriangle()
        {
            List<uint> triangle = new List<uint>();

            for (int i = 0; i < 3;)
            {
                triangle.Add(GetSide());
            }

            return triangle;
        }

        static string OutputTriangleType(List<uint> lenghts)
        {
            if (lenghts[0] == lenghts[1])
            {
                if (lenghts[1] == lenghts[2])
                {
                    return "Equilateral Triangle";
                }
                return "Isosceles Triangle";
            }
            else if (lenghts[0] == lenghts[2])
            {
                return "Isosceles Triangle";
            }
            return "Scalene Triangle";
        }

        static void Main(string[] args)
        {
            while (true)
            {
                List<uint> triangle = GetTriangle();

                if (ValidateTriangle(triangle))
                {
                    Console.WriteLine(OutputTriangleType(triangle));
                }
                else
                {
                    Console.WriteLine("Not a valid triangle");
                }
                Console.WriteLine("Try again");
            }
        }
    }
}
