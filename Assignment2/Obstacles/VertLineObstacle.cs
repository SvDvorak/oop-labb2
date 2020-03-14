using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class VertLineObstacle : IStraightLine
    {

        public Position Position { get; set; }
        public Pen Pen { get; set; }
        public float EndPositionX { get; set; }
        public float EndPositionY { get; set; }

        public VertLineObstacle(float x, float y, float endPositionX, float endPositionY)
        {
            Position = new Position(x, y);
            this.EndPositionX = endPositionX;
            this.EndPositionY = endPositionY;
            Pen = new Pen(Color.Yellow);
        }

        public void CreateShape(Graphics g)
        {
            g.DrawLine(Pen, Position.X, Position.Y, EndPositionX, EndPositionY);
        }

    }
}
