using Assignment2.Drawing;

namespace Assignment2.Physics
{
    public interface IObstacle : IDrawable
    {
        void HandleCollision(Ball ball);
    }
}
