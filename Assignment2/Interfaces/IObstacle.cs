using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IObstacle
    {
        Position Position { get; set; }
        Pen Pen { get; set; }
        void CreateShape(Graphics g);

    }
}
