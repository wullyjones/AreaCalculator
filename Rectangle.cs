using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Rectangle : Shape
    {
        private double length;
        private double height;

        public Rectangle()
        {
            length = 0;
            height = 0;
        }

        public Rectangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public virtual void setHeight(double height)
        {
            this.height = height;
        }

        public override double getArea()
        {
            return Math.Round(length * height, 2);
        }
    }
}
