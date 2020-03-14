using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Assignment2.Shapes;

namespace Assignment2
{
	public class Engine
	{
		private MainForm Form;
		private Timer Timer;

		private ISet<Ball> Balls = new HashSet<Ball>();
        private List<IObstacle> ObstacleList;

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
            var redbox1 = new RedBoxObstacle(670, 370, 40, 80);
			ObstacleList.Add();
			var redbox2 = new RedBoxObstacle(145, 135, 60, 60);

            var bluebox1 = new BlueBoxObstacle(50, 500, 250, 25);
			var bluebox2 = new BlueBoxObstacle(540, 60, 60, 60);

			var hor1 = new HorLineObstacle(10, 550, 700, 550);
            var hor2 = new HorLineObstacle(550, 500, 740, 500);
            var hor3 = new HorLineObstacle(180, 450, 630, 450);
            var hor4 = new HorLineObstacle(120, 110, 370, 110);
            var hor5 = new HorLineObstacle(50, 30, 300, 30);
            var hor6 = new HorLineObstacle(400, 30, 670, 30);

            var ver1 = new VertLineObstacle(750, 30, 750, 530);
            var ver2 = new VertLineObstacle(80, 60, 80, 200);
			var ver3 = new VertLineObstacle(15, 70, 15, 600);






			redbox1.CreateShape(args.Graphics);
			redbox2.CreateShape(args.Graphics);

            bluebox1.CreateShape(args.Graphics);
			bluebox2.CreateShape(args.Graphics);

			hor1.CreateShape(args.Graphics);
            hor2.CreateShape(args.Graphics);
            hor3.CreateShape(args.Graphics);
            hor4.CreateShape(args.Graphics);
            hor5.CreateShape(args.Graphics);
            hor6.CreateShape(args.Graphics);

            ver1.CreateShape(args.Graphics);
            ver2.CreateShape(args.Graphics);
			ver3.CreateShape(args.Graphics);




			foreach (var ball in Balls)
			{
				ball.Draw(args.Graphics);
			}
		}

	}
}
