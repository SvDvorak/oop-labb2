using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
	public class Engine
	{
		private MainForm Form;
		private Timer Timer;

		private ISet<Ball> Balls = new HashSet<Ball>();

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
            var verLine = new VerLine(600, 300, 80, 50);
			verLine.CreateShape(args.Graphics);

			foreach (var ball in Balls)
			{
				ball.Draw(args.Graphics);
			}
		}

	}
}
