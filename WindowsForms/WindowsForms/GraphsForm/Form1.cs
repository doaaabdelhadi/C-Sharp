using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphsForm
{
    public partial class Ball_play : Form
    {
        public Ball_play()
        {
            InitializeComponent();
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            graph.FillEllipse(Brushes.DarkOrange, x, 60, 50, 50);
        }

        private void Ball_Load(object sender, EventArgs e)
        {

        }
        int x=60;
        bool flag = false;
        int r = 250;
        int g = 250;
        int b = 250;
        //int max = 250;
        //int min = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            r = Convert.ToInt32(this.Red_conuter.Value);
            g = Convert.ToInt32(this.Green_count.Value);
            b = Convert.ToInt32(this.Bule_count.Value);

            Graphics graph = this.CreateGraphics();
            SolidBrush s = new SolidBrush(this.BackColor);
            SolidBrush BallColor = new SolidBrush(Color.FromArgb(r, g, b));
            graph.FillEllipse(s, x, 60, 50, 50);


            if (x >= this.ClientSize.Width - 50)
            {
                flag = true;


            }
            if (x <= 0)
            {
                flag = false;
            }
            if (flag == true)
            {
                x -= 5;
                /*if (r <= 250 || g <= 250  && r == 0 || g == 0 )
                {
                    r += 20;
                    g += 20;
                    //b -= 20;

                }
                else
                {
                    r -= 60;
                    g -= 60;
                    //b += 20;
                }*/



            }
            else
            {
                x += 5;
               /* if (r <= max || g <= 250  && r == 0 || g == 0)
                  {
                      r -= 20;
                      g -= 20;
                      //b += 20;

                  }
                else
                {
                    r += 60;
                    g += 60;
                    //b -= 20;
                }*/
             





            }
            //x += 5;
            graph.FillEllipse(BallColor, x, 60, 50, 50);
            this.Text = x.ToString();
        }

        private void But_Control_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
            if (this.timer1.Enabled == false)
            {
                this.But_Control.Text = "Start";
                this.But_Control.BackColor = Color.OrangeRed;
            }
            else
            {
                this.But_Control.Text = "Stop";
                this.But_Control.BackColor = Color.Green;
            }
        }

        private void Red_conuter_ValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
