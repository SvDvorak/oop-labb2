using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2.Obstacles
{
    class HorLineObstacle : IBox
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Position Position { get; set; }
        public Pen Pen { get; set; }

        public HorLineObstacle(float x, float y, int width, int height)
        {
            Width = width;
            Height = height;
            Pen = new Pen(Color.Green);
            Position = new Position(x, y);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Position.X, Position.Y, Width, Height);
        }

        //Implements the same collision as rectangles/boxes because I treat the lines as rectangles with 1px width or height
        public void HandleCollision(Ball ball)
        {
            if(Physics.BoxCollidesWithBall(this, ball))
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
