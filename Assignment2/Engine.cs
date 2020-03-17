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

        private List<object> GameObjects = new List<object>();

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
			GameObjects.Add(new RedBoxObstacle(670, 370, 40, 80));
			GameObjects.Add(new RedBoxObstacle(145, 135, 60, 60));

			//Blue rectangles
            GameObjects.Add(new BlueBoxObstacle(500, 70, 70, 70));
            GameObjects.Add(new BlueBoxObstacle(100, 480, 200, 30));

			//Horizontal lines
			GameObjects.Add(new HorLineObstacle(10, 550, 700, 1));
			GameObjects.Add(new HorLineObstacle(450, 500, 280, 1));
			GameObjects.Add(new HorLineObstacle(180, 450, 400, 1));
			GameObjects.Add(new HorLineObstacle(50, 30, 280, 1));
			GameObjects.Add(new HorLineObstacle(120, 110, 240, 1));
			GameObjects.Add(new HorLineObstacle(400, 30, 300, 1));

			//Vertical lines
			GameObjects.Add(new VerLineObstacle(750, 30, 1, 530));
			GameObjects.Add(new VerLineObstacle(80, 70, 1, 200));
			GameObjects.Add(new VerLineObstacle(15, 80, 1, 600));


			Application.Run(Form);
		}

		private void TimerEventHandler(Object obj, EventArgs args)
		{

			if (Random.Next(100) < 25)
            {
				var ball = new Ball(400, 300, 10);
				ball.Speed = new Vector(Random.Next(10) - 5, Random.Next(10) - 5);
				//if (Balls.Count < 3)
					GameObjects.Add(ball);
			}

            foreach (IObstacle obs in GameObjects)
            {
				foreach (Ball ball in GameObjects)
				{
					obs.HandleCollision(ball);
				}
            }

			foreach (Ball ball in GameObjects)
			{
				ball.Move();
			}

			Form.Refresh();
		}

		private void Draw(Object obj, PaintEventArgs args)
		{
            foreach (IDrawable obs in GameObjects)
            {
                obs.Draw(args.Graphics);
            }
		}
	}
}
