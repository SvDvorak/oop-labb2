using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IStraightLine : IObstacle
    {
        float EndPositionX { get; set; }
        float EndPositionY { get; set; }

    }
}
