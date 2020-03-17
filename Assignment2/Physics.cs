
using System;
using System.Collections.Generic;
using Assignment2.Interfaces;

namespace Assignment2
{
    static class Physics
    {
        public static bool BoxCollidesWithBall(IBox box, Ball ball)
        {
            double DeltaX = ball.Position.X - Math.Max(box.Position.X, Math.Min(ball.Position.X, box.Position.X + box.Width));
            double DeltaY = ball.Position.Y - Math.Max(box.Position.Y, Math.Min(ball.Position.Y, box.Position.Y + box.Height));
            return (DeltaX * DeltaX + DeltaY * DeltaY) < ball.Radius * ball.Radius;
        }
    }
}