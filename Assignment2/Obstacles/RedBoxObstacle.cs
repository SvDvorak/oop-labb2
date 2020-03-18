using System.Drawing;
using Assignment2.Drawing;
using Assignment2.Physics;

namespace Assignment2.Obstacles
{
    class RedBoxObstacle: IObstacle
    {
        private readonly CollisionBox Collider;
        private readonly RectangleGraphic Drawable;

        public RedBoxObstacle(float x, float y, int width, int height)
        {
            var rectangle = new Rectangle(x, y, width, height);
            Drawable = new RectangleGraphic(Color.Red, rectangle);
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
            double boostSpeed = 0.05;
            ball.Speed = new Vector(ball.Speed.X + ball.Speed.X * (float)boostSpeed, ball.Speed.Y + ball.Speed.Y * (float)boostSpeed);
        }
    }
}
