using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidthHeightTriangle
{
    internal class Triangle
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public float GetArea()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return Width + Height + Math.Sqrt(Width * Width + Height * Height);
        }

        public float Diagonal()
        {
            return (float)Math.Sqrt(Width * Width + Height * Height);
        }
    }
}
