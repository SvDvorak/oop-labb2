using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2.Interfaces;

namespace Assignment2
{
    class RedBoxObstacle : IBox
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Position Position { get; set; }
        public Pen Pen { get; set; }

        public RedBoxObstacle(float x, float y, int width, int height)
        {
            Width = width;
            Height = height;
            Pen = new Pen(Color.Red);
            Position = new Position(x, y);
        }

        public void DrawObstacle(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }
    }

}
