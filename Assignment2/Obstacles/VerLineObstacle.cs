using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2.Obstacles
{
    class VerLineObstacle : IBox
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Position Position { get; set; }
        public Pen Pen { get; set; }

        public VerLineObstacle(float x, float y, int width, int height)
        {
            Width = width;
            Height = height;
            Pen = new Pen(Color.Yellow);
            Position = new Position(x, y);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }

        //Implements the same collision as rectangles/boxes lines are treated the same as rectangles with 1px width or height
        public void HandleCollision(Ball ball)
        {
            if(Physics.BoxCollidesWithBall(this, ball))
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
