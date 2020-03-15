using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Interfaces
{
    public interface ILineCollision
    {
        void DetectCircle(ISet<Ball> Balls);
    }
}
