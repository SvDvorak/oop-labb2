using System.Drawing;
using Assignment2.Interfaces;
using Assignment2.Physics;

namespace Assignment2.Obstacles
{
    class BlueBoxObstacle : IObstacle
    {
        private ICollider Collider;
        private IDrawable Drawable;

        public BlueBoxObstacle(float x, float y, int width, int height)
        {
            var rectangle = new Rectangle(x, y, width, height);
            Drawable = new RectangleGraphic(Color.DodgerBlue, rectangle);
            Collider = new CollisionBox(rectangle);
        }

        public void Draw(Graphics g)
        {
            Drawable.Draw(g);
        }

        public void HandleCollision(Ball ball)
        {
            if(Collider.CollidesWith(ball))
            {
                SpeedUp(ball);
            }
        }

        private void SpeedUp(Ball ball)
        {
            double boostSpeed = -0.05;
            if (ball.Speed.X > 1 || ball.Speed.X < -1)
            {
                ball.Speed = new Vector(ball.Speed.X + ball.Speed.X * (float)boostSpeed, ball.Speed.Y + ball.Speed.Y * (float)boostSpeed);
            }
        }
    }
}
