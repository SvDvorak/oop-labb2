using System;
using System.Collections.Generic;
using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2.Obstacles
{
    class RedBoxObstacle: IBox
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

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }

        public void HandleCollision(Ball ball)
        {
            if(Physics.BoxCollidesWithBall(this, ball))
            {
                SlowDown(ball);
            }
        }

        private void SlowDown(Ball ball)
        {
            double boostSpeed = 0.05;
            ball.Speed = new Vector(ball.Speed.X + ball.Speed.X * (float)boostSpeed, ball.Speed.Y + ball.Speed.Y * (float)boostSpeed);
        }
    }
}
