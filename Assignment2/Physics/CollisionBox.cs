using System;

namespace Assignment2.Physics
{
    public class CollisionBox : ICollider
    {
        private readonly Rectangle rect;

        public CollisionBox(Rectangle rectangle)
        {
            rect = rectangle;
        }

        public bool CollidesWith(Ball ball)
        {
            double DeltaX = ball.Position.X - Math.Max(rect.Pos.X, Math.Min(ball.Position.X, rect.Pos.X + rect.Width));
            double DeltaY = ball.Position.Y - Math.Max(rect.Pos.Y, Math.Min(ball.Position.Y, rect.Pos.Y + rect.Height));
            return (DeltaX * DeltaX + DeltaY * DeltaY) < ball.Radius * ball.Radius;
        }
    }
}