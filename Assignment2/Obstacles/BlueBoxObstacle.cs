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

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }

        public void HandleCollision(Ball ball)
        {
            if(Physics.BoxCollidesWithBall(this, ball))
            {
                SpeedUp(ball);
            }
        }

        public void SpeedUp(Ball ball)
        {
            double boostSpeed = -0.05;
            if (ball.Speed.X > 1 || ball.Speed.X < -1)
            {
                ball.Speed = new Vector(ball.Speed.X + ball.Speed.X * (float)boostSpeed, ball.Speed.Y + ball.Speed.Y * (float)boostSpeed);
            }
        }
    }
}
