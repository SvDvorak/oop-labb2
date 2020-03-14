using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    class VerLine : IObstacles
    {
        public float Width;
        public float Height;
        public Position Position { get; set; }
        public Pen Pen { get; set; }

        public VerLine(float x, float y, int width, int height)
        {
            Width = width;
            Height = height;
            Pen = new Pen(Color.Yellow);
            Position = new Position(x, y);
        }

        public void CreateShape(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }


    }
}
