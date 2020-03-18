using System.Collections.Generic;
using Assignment2.Drawing;
using Assignment2.Obstacles;
using Assignment2.Physics;

namespace Assignment2
{
    public class Scene
    {
        public List<Ball> Balls = new List<Ball>();
        public List<IObstacle> Collideables = new List<IObstacle>();
        public List<IDrawable> Drawables = new List<IDrawable>();
        public List<IUpdateable> Updateables = new List<IUpdateable>();

        public void AddBall(int speedX, int speedY)
        {
            var ball = new Ball(400, 300, 10)
            {
                Speed = new Vector(speedX, speedY)
            };
            //if (Balls.Count < 3)
            Balls.Add(ball);
            Drawables.Add(ball);
            Updateables.Add(ball);
        }

        public void AddBoostBox(float x, float y, int width, int height)
        {
            var obj = new RedBoxObstacle(x, y, width, height);
            Collideables.Add(obj);
            Drawables.Add(obj);
        }

        public void AddSlowDownBox(float x, float y, int width, int height)
        {
            var obj = new BlueBoxObstacle(x, y, width, height);
            Collideables.Add(obj);
            Drawables.Add(obj);
        }

        public void AddHorLine(float x, float y, int width)
        {
            var obj = new HorLineObstacle(x, y, width, 1);
            Collideables.Add(obj);
            Drawables.Add(obj);
        }

        public void AddVerLine(float x, float y, int height)
        {
            var obj = new VerLineObstacle(x, y, 1, height);
            Collideables.Add(obj);
            Drawables.Add(obj);
        }
    }
}