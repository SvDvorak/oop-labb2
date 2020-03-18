using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2.Obstacles
{
    internal class RectangleGraphic : IDrawable
    {
        private readonly Pen pen;
        private readonly Rectangle rect;

        public RectangleGraphic(Color color, Rectangle rect)
        {
            pen = new Pen(color);
            this.rect = rect;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rect.Pos.X, rect.Pos.Y, rect.Width, rect.Height);
        }
    }
}