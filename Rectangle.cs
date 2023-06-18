using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal class Rectangle :Shape
    {
        double Width;
        double Height;

        public Rectangle(string color,  double width, double height) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }

        public double area()
        {
            return this.Width * this.Height;
        }
    }
}
