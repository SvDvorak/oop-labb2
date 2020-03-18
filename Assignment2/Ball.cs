using System.Drawing;
using Assignment2.Drawing;

namespace Assignment2
{
	public class Ball : IDrawable, IUpdateable
    {
        private readonly EllipseGraphic Drawable;

		public Position Position { get; set; }
        public float Radius { get; set; }
		public Vector Speed { get; set; }

		public Ball(float x, float y, float radius)
		{
			Position = new Position(x,y);
            Radius = radius;

			Drawable = new EllipseGraphic(Color.WhiteSmoke, Position, radius);
		}

        public void Draw(Graphics g)
		{
			Drawable.Draw(g);
		}

        public void Update()
        {
            Move();
        }

        public void Move()
        {
            Position = new Position(Position.X + Speed.X, Position.Y + Speed.Y);
            Drawable.Position = Position;
        }
    }

    public interface IUpdateable
    {
        void Update();
    }
}
