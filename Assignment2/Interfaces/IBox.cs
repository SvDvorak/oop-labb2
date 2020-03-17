using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Interfaces
{
    public interface IBox : IObstacle
    {
        float Width { get; set; }
        float Height { get; set; }
        void DetectCircle(ISet<Ball> Balls);
    }
}
