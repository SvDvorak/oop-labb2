using System;
using System.Drawing;

namespace Assignment2
{
	public class Ball
	{
		Pen Pen = new Pen(Color.WhiteSmoke);

		Position Position;
		public Vector Speed { get; set; }

		float Radius;

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
