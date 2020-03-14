using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HorLineObstacle : IStraightLine
    {
        public Position Position { get; set; }
        public Pen Pen { get; set; }
        public float EndPositionX { get; set; }
        public float EndPositionY { get; set; }

        public HorLineObstacle(float x, float y, float endPositionX, float endPositionY)
        {
            Position = new Position(x, y);
            this.EndPositionX = endPositionX;
            this.EndPositionY = endPositionY;
            Pen = new Pen(Color.Green);
        }

        public void CreateShape(Graphics g)
        {
            g.DrawLine(Pen, Position.X, Position.Y, EndPositionX, EndPositionY);
        }

    }
}
