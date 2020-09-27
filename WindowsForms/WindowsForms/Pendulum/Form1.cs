using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum
{
    public partial class Pendulum_display : Form
    {
        public Pendulum_display()
        {
            InitializeComponent();
        }

        private void Pendulum_display_Paint(object sender, PaintEventArgs e)
        {
            Graphics ball = e.Graphics;
            Pen pen_line = new Pen(Color.Black, 3);

            ball.FillEllipse(Brushes.Black, 200, 50, 50, 50);

            ball.DrawLine(pen_line, 220, 70, 220, 0);
        }
        int x = 200;
        int y = 220;

        bool flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Value = 5;
            Pen pen_s = new Pen(this.BackColor, 3);
            Graphics graph = this.CreateGraphics();
            SolidBrush s = new SolidBrush(this.BackColor);
            SolidBrush BallColor = new SolidBrush(Color.DeepPink);
            graph.FillEllipse(s, x, 50, 50, 50);
            graph.DrawLine(pen_s, y, 70, 220, 0);

            if (x >= this.ClientSize.Width - 175)
            {
                flag = true;


            }
            if (x <= 80)
            {
                flag = false;
            }
            if (flag == true)
            {
                x -= 5;
                y -= 5;
               
                if (progressBar1.Value > 3)
                {
                    progressBar1.Value -= 3;
                }
               


            }
            else
            {
                x += 5;
                y += 5;
                if (progressBar1.Value <97 )
                {
                    progressBar1.Value += 3;
                }

            }
            Pen pen_line = new Pen(Color.DeepPink, 3);
            graph.FillEllipse(BallColor, x, 50, 50, 50);
            graph.DrawLine(pen_line, y, 70, 220, 0);
            this.Text = x.ToString();

        }

        private void Display_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
            if (this.timer1.Enabled == false)
            {
                this.Display.Text = "Start";
                this.Display.BackColor = Color.GreenYellow;

            }
            else
            {
                this.Display.Text = "Stop";
                this.Display.BackColor = Color.DeepPink;
                

            }
        }

        private void Pendulum_display_Load(object sender, EventArgs e)
        {

        }

       
    }
}
