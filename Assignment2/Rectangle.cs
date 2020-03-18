using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public struct Rectangle
    {
        public Position Pos;
        public float Width, Height;

        public Rectangle(float x, float y, float width, float height)
        {
            Pos = new Position(x, y);
            Width = width;
            Height = height;
        }
    }
}
