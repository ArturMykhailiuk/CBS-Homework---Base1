using System;

namespace CBS_Homework___Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure();
            Console.WriteLine(triangle.CalculatePerimeter());
            Console.WriteLine(triangle.Name);
            Console.ReadKey();
        }
    }
}
