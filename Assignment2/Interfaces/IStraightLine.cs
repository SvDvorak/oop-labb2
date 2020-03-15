using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Interfaces;

namespace Assignment2
{
    public interface IStraightLine : IObstacle, ILineCollision
    {
        float EndPositionX { get; set; }
        float EndPositionY { get; set; }

    }
}
