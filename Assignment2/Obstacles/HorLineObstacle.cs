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

        public void DrawObstacle(Graphics g)
        {
            g.DrawLine(Pen, Position.X, Position.Y, EndPositionX, EndPositionY);
        }

        public void DetectCircle(ISet<Ball> Balls)
        {
            //B = Position
            // A = End
            foreach (var ball in Balls)
            {
                //euclidian distance between A and B
                double LAB = Math.Sqrt(Math.Pow(Position.X - EndPositionX, 2) + Math.Pow(Position.Y - EndPositionY, 2));

                double Dx = (Position.X - EndPositionX) / LAB;
                double Dy = (Position.Y - EndPositionY) / LAB;

                double t = Dx * (ball.Position.X - EndPositionX) + Dy * (ball.Position.Y - EndPositionY);
                double Ex = t * Dx + EndPositionX;
                double Ey = t * Dy + EndPositionY;
                double LEC = Math.Sqrt(Math.Pow(Ex - ball.Position.X, 2) + Math.Pow(Ey - ball.Position.Y, 2));

                if (LEC < (double)ball.Radius)
                {
                    double dt = Math.Sqrt(Math.Pow(ball.Radius, 2) - Math.Pow(LEC, 2));

                    //First intersection point

                    //double Fx = (t - dt) * Dx + EndPositionX;
                    //double Fy = (t - dt) * Dy + EndPositionY;

                    //double Gx = (t + dt) * Dx + EndPositionX;
                    //double Gy = (t + dt) * Dy + EndPositionY;
                }
                //tangeringspunkten till cirkeln är Ex & Ey
                else if (LEC == ball.Radius)
                {
                    //Ändrar X-värdet
                    ball.ReflectX();
                }

            }
           

        }
    }
}
