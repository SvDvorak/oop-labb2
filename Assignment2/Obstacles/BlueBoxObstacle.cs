using System;
using System.Collections.Generic;
using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2.Obstacles
{
    class BlueBoxObstacle : IBox
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Position Position { get; set; }
        public Pen Pen { get; set; }

        public BlueBoxObstacle(float x, float y, int width, int height)
        {
            Width = width;
            Height = height;
            Pen = new Pen(Color.DodgerBlue);
            Position = new Position(x, y);
        }

        public void DrawObstacle(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }

        public void DetectCircle(ISet<Ball> Balls)
        {

            foreach (var ball in Balls)
            {
                double DeltaX = ball.Position.X - Math.Max(Position.X, Math.Min(ball.Position.X, Position.X + Width));
                double DeltaY = ball.Position.Y - Math.Max(Position.Y, Math.Min(ball.Position.Y, Position.Y + Height));
                if ((DeltaX * DeltaX + DeltaY * DeltaY) < ball.Radius * ball.Radius)
                {
                    ball.DecreaseSpeed();
                }
            }
        }
    }
}
