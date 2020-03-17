using System.Collections.Generic;
using System.Drawing;

namespace Assignment2.Interfaces
{
    public interface IObstacle: IDrawable
    {
        Position Position { get; set; }
        Pen Pen { get; set; }
        void HandleCollision(Ball ball);
    }
}
