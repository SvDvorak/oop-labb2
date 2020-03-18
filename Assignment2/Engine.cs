using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public class Engine
	{
		private MainForm Form;
		private Timer Timer;
		private Random Random = new Random();
        private Scene Scene;

		public Engine()
		{
			Form = new MainForm();
			Form.BackColor = Color.Black;
            Timer = new Timer();
            Scene = new Scene();
        }

        public void Run()
		{
            Form.Paint += Draw;
			Timer.Tick += TimerEventHandler;
			Timer.Interval = 1000/25;
			Timer.Start();

			//Red rectangles
			Scene.AddBoostBox(670, 370, 40, 80);
			Scene.AddBoostBox(145, 135, 60, 60);

			//Blue rectangles
            Scene.AddSlowDownBox(500, 70, 70, 70);
            Scene.AddSlowDownBox(100, 480, 200, 30);

			//Horizontal lines
			Scene.AddHorLine(10, 550, 700);
			Scene.AddHorLine(450, 500, 280);
            Scene.AddHorLine(180, 450, 400);
			Scene.AddHorLine(50, 30, 280);
			Scene.AddHorLine(120, 110, 240);
			Scene.AddHorLine(400, 30, 300);

			//Vertical lines
			Scene.AddVerLine(750, 30, 530);
			Scene.AddVerLine(80, 70, 200);
			Scene.AddVerLine(15, 80, 600);


			Application.Run(Form);
		}

        private void TimerEventHandler(object obj, EventArgs args)
		{
			if (Random.Next(100) < 25)
            {
                Scene.AddBall(Random.Next(10) - 5, Random.Next(10) - 5);
            }

            foreach (var obs in Scene.Collideables)
            {
				foreach (var ball in Scene.Balls)
				{
					obs.HandleCollision(ball);
				}
            }

			foreach (var updateable in Scene.Updateables)
			{
				updateable.Update();
			}

			Form.Refresh();
		}

        private void Draw(object obj, PaintEventArgs args)
		{
            foreach (var drawable in Scene.Drawables)
            {
                drawable.Draw(args.Graphics);
            }
		}
	}
}
