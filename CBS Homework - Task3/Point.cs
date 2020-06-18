using System;
using System.Collections.Generic;
using System.Text;

namespace CBS_Homework___Task3
{
    public class Point
    {
        string name;
        int x, y;
        
        public int X
        {
            get
            {
                return x;
            }
        }
        
        public int Y
        {
            get
            {
                return y;
            }
        }
        
        public string Name
        {
            get
            {
                return name;
            }
        }
        
        public Point()
            : this("", 0, 0) { }
        
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Имя точки:");
            this.name = Console.ReadLine();
            Console.WriteLine("Координата X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y:");
            this.y = int.Parse(Console.ReadLine());
        }

    }
}
