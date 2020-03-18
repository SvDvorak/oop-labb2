using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Assignment2.Interfaces;
using Assignment2.Obstacles;

namespace Assignment2
{
	public class Engine
	{
		private MainForm Form;
		private Timer Timer;
		private Random Random = new Random();

        private List<Ball> Balls = new List<Ball>();
        private List<IObstacle> Obstacles = new List<IObstacle>();

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

			//Red rectangles
			Obstacles.Add(new RedBoxObstacle(670, 370, 40, 80));
			Obstacles.Add(new RedBoxObstacle(145, 135, 60, 60));

			//Blue rectangles
            Obstacles.Add(new BlueBoxObstacle(500, 70, 70, 70));
            Obstacles.Add(new BlueBoxObstacle(100, 480, 200, 30));

			//Horizontal lines
			Obstacles.Add(new HorLineObstacle(10, 550, 700, 1));
			Obstacles.Add(new HorLineObstacle(450, 500, 280, 1));
			Obstacles.Add(new HorLineObstacle(180, 450, 400, 1));
			Obstacles.Add(new HorLineObstacle(50, 30, 280, 1));
			Obstacles.Add(new HorLineObstacle(120, 110, 240, 1));
			Obstacles.Add(new HorLineObstacle(400, 30, 300, 1));

			//Vertical lines
			Obstacles.Add(new VerLineObstacle(750, 30, 1, 530));
			Obstacles.Add(new VerLineObstacle(80, 70, 1, 200));
			Obstacles.Add(new VerLineObstacle(15, 80, 1, 600));


			Application.Run(Form);
		}

		private void TimerEventHandler(Object obj, EventArgs args)
		{

			if (Random.Next(100) < 25)
            {
				var ball = new Ball(400, 300, 10);
				ball.Speed = new Vector(Random.Next(10) - 5, Random.Next(10) - 5);
				//if (Balls.Count < 3)
					Balls.Add(ball);
			}

            foreach (var obs in Obstacles)
            {
				foreach (var ball in Balls)
				{
					obs.HandleCollision(ball);
				}
            }

			foreach (var ball in Balls)
			{
				ball.Move();
			}

			Form.Refresh();
		}

		private void Draw(Object obj, PaintEventArgs args)
		{
            foreach (var obs in Obstacles)
            {
                obs.Draw(args.Graphics);
            }

            foreach (var obs in Balls)
            {
                obs.Draw(args.Graphics);
            }
		}
	}
}
