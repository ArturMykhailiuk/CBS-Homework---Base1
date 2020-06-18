using System;
using System.Collections.Generic;
using System.Text;

namespace CBS_Homework___Base1
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle()
        { }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side1;
        }

        public double Area
        {
            get { return side1 * side2; }
        }

        public double Perimetr
        {
            get { return 2 * side1 + 2 * side2; }
        }



    }
}
