using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Assignment2.Interfaces;
using Assignment2.Shapes;

namespace Assignment2
{
	public class Engine
	{
		private MainForm Form;
		private Timer Timer;

		private ISet<Ball> Balls = new HashSet<Ball>();
        private List<IObstacle> obstacles = new List<IObstacle>();



		private Random Random = new Random();

		public Engine()
		{
			Form = new MainForm();
			Form.BackColor = Color.Black;
            Timer = new Timer();

        }

		public void Run()
		{
            Form.Paint += Draw;
			Timer.Tick += TimerEventHandler;
			Timer.Interval = 1000/25;
			Timer.Start();

            obstacles.Add(new RedBoxObstacle(670, 370, 40, 80));
            obstacles.Add(new RedBoxObstacle(145, 135, 60, 60));
            obstacles.Add(new BlueBoxObstacle(50, 500, 250, 25));
            obstacles.Add(new BlueBoxObstacle(540, 60, 60, 60));
            obstacles.Add(new HorLineObstacle(10, 550, 700, 550));
            obstacles.Add(new HorLineObstacle(550, 500, 740, 500));
            obstacles.Add(new HorLineObstacle(180, 450, 630, 450));
            obstacles.Add(new HorLineObstacle(50, 30, 300, 30));
            obstacles.Add(new HorLineObstacle(120, 110, 370, 110));
            obstacles.Add(new HorLineObstacle(50, 30, 300, 30));
            obstacles.Add(new HorLineObstacle(400, 30, 670, 30));
            obstacles.Add(new VertLineObstacle(750, 30, 750, 530));
            obstacles.Add(new VertLineObstacle(80, 60, 80, 200));
            obstacles.Add(new VertLineObstacle(15, 70, 15, 600));

			Application.Run(Form);

		}

		private void TimerEventHandler(Object obj, EventArgs args)
		{

			if (Random.Next(100) < 25)
            {
				var ball = new Ball(400, 300, 10);
				ball.Speed = new Vector(Random.Next(10) - 5, Random.Next(10) - 5);
				Balls.Add(ball);
			}

			foreach (var ball in Balls)
			{
				ball.Move();
			}

			Form.Refresh();
		}

		private void Draw(Object obj, PaintEventArgs args)
		{
            foreach (IObstacle obs in obstacles)
            {
                obs.DrawObstacle(args.Graphics);
                if (obs is ILineCollision line)
                {
					line.DetectCircle(Balls);
                }
            }

			foreach (var ball in Balls)
			{
				ball.Draw(args.Graphics);
            }
		}

	}
}
