using System.Drawing;

namespace Assignment2.Interfaces
{
    public interface IObstacle
    {
        Position Position { get; set; }
        Pen Pen { get; set; }
        void DrawObstacle(Graphics g);

    }
}
