using System.Drawing;

namespace Assignment2.Drawing
{
    class EllipseGraphic
    {
        private readonly Pen pen;
        private readonly float radius;

        public Position Position { get; set; }

        public EllipseGraphic(Color color, Position pos, float radius)
        {
            pen = new Pen(color);
            Position = pos;
            this.radius = radius;
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(pen, Position.X - radius, Position.Y - radius, 2 * radius, 2 * radius);
        }
    }
}