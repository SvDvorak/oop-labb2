using System.Drawing;
using Assignment2.Interfaces;
using Assignment2.Physics;

namespace Assignment2.Obstacles
{
    class HorLineObstacle : IObstacle
    {
        private ICollider Collider;
        private IDrawable Drawable;

        public HorLineObstacle(float x, float y, int width, int height)
        {
            var rectangle = new Rectangle(x, y, width, height);
            Drawable = new RectangleGraphic(Color.Green, rectangle);
            Collider = new CollisionBox(rectangle);
        }

        public void Draw(Graphics g)
        {
            Drawable.Draw(g);
        }

        //Implements the same collision as rectangles/boxes because I treat the lines as rectangles with 1px width or height
        public void HandleCollision(Ball ball)
        {
            if(Collider.CollidesWith(ball))
            {
                Reflect(ball);
            }
        }

        //Reflects by inverting the Y-value of the ball
        private void Reflect(Ball ball)
        {
            float ySpeed = ball.Speed.Y * -1;
            ball.Speed = new Vector(ball.Speed.X, ySpeed);
        }
    }
}
