using System.Drawing;
using Assignment2.Interfaces;
using Assignment2.Physics;

namespace Assignment2.Obstacles
{
    class VerLineObstacle : IObstacle
    {
        private ICollider Collider;
        private IDrawable Drawable;

        public VerLineObstacle(float x, float y, int width, int height)
        {
            var rectangle = new Rectangle(x, y, width, height);
            Drawable = new RectangleGraphic(Color.Yellow, rectangle);
            Collider = new CollisionBox(rectangle);
        }

        public void Draw(Graphics g)
        {
            Drawable.Draw(g);
        }

        //Implements the same collision as rectangles/boxes lines are treated the same as rectangles with 1px width or height
        public void HandleCollision(Ball ball)
        {
            if(Collider.CollidesWith(ball))
            {
                Reflect(ball);
            }
        }

        //Reflects by inverting the X-value of the ball
        private void Reflect(Ball ball)
        {
            float xSpeed = ball.Speed.X * -1;
            ball.Speed = new Vector(xSpeed, ball.Speed.Y);
        }
    }
}
