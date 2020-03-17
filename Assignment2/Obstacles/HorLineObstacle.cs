using System;
using System.Collections.Generic;
using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2.Obstacles
{
    class HorLineObstacle : IBox, IReflectable
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Position Position { get; set; }
        public Pen Pen { get; set; }

        public HorLineObstacle(float x, float y, int width, int height)
        {
            Width = width;
            Height = height;
            Pen = new Pen(Color.Green);
            Position = new Position(x, y);
        }

        public void DrawObstacle(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }

        //Implements the same collision as rectangles/boxes because I treat the lines as rectangles with 1px width or height
        public void BoxToCircleCollision(ISet<Ball> Balls)
        {
            foreach (var ball in Balls)
            {
                double DeltaX = ball.Position.X - Math.Max(Position.X, Math.Min(ball.Position.X, Position.X + Width));
                double DeltaY = ball.Position.Y - Math.Max(Position.Y, Math.Min(ball.Position.Y, Position.Y + Height));

                if ((DeltaX * DeltaX + DeltaY * DeltaY) < ball.Radius * ball.Radius)
                {
                    Reflect(ball);
                }
            }
        }

        //Reflects by inverting the Y-value of the ball
        public void Reflect(Ball ball)
        {
            float ySpeed = ball.Speed.Y * -1;
            ball.Speed = new Vector(ball.Speed.X, ySpeed);
        }
    }
}
