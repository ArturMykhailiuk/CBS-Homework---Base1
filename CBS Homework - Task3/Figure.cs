using System;
using System.Collections.Generic;
using System.Text;

namespace CBS_Homework___Task3
{
    class Figure
    {
        int number;
        Point[] points;
        string name;
        
        public Figure ()
        {
            InitializeFigure();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        
        public void InitializeFigure()
        {
            Console.WriteLine("Задайте количество вершин");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 3:
                    {
                        this.name = "Треугольник";
                        break;
                    }
                case 4:
                    {
                        this.name = "Прямоугольник";
                        break;
                    }
                case 5:
                    {
                        this.name = "Пятиугольник";
                        break;
                    }
                default:
                    {
                        this.name = "Зверушка страшная, но прикольная";
                        break;
                    }
            } 

            points = new Point[number];
            for (int i = 0; i < number; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
    }
}
