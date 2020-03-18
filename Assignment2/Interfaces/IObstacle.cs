namespace Assignment2.Interfaces
{
    public interface IObstacle : IDrawable
    {
        void HandleCollision(Ball ball);
    }
}
