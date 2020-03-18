using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
