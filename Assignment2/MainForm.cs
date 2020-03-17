using System;
using System.Windows.Forms;


namespace Assignment2
{
	public class MainForm : Form
	{
		public MainForm() : base()
		{
			Text = "Assignment 2";
			Width = 800;
			Height = 600;
		}

		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
