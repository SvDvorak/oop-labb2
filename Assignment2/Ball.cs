using System;
using System.Drawing;
using Assignment2.Interfaces;

namespace Assignment2
{
	public class Ball : IDrawable
	{
		Pen Pen = new Pen(Color.WhiteSmoke);

		public Position Position;
		public Vector Speed { get; set; }
		public float Radius { get; set; }

		public Ball(float x, float y, float radius)
		{
			Position = new Position(x,y); Radius = radius;
		}

		public void Draw(Graphics g)
		{
			g.DrawEllipse(Pen,Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);
		}

		public void Move()
		{
			Position.X += Speed.X;
			Position.Y += Speed.Y;
		}

    }
}
