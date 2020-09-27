namespace Pendulum
{
    partial class Pendulum_display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pendulum_display));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Display = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ITI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.GreenYellow;
            this.Display.Font = new System.Drawing.Font("Italic Outline Art", 10F, System.Drawing.FontStyle.Bold);
            this.Display.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Display.Location = new System.Drawing.Point(175, 235);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(107, 37);
            this.Display.TabIndex = 0;
            this.Display.Text = "Start";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.GreenYellow;
            this.progressBar1.ForeColor = System.Drawing.Color.DeepPink;
            this.progressBar1.Location = new System.Drawing.Point(175, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 15);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 5;
            // 
            // ITI
            // 
            this.ITI.AutoSize = true;
            this.ITI.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ITI.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITI.ForeColor = System.Drawing.Color.DeepPink;
            this.ITI.Location = new System.Drawing.Point(12, 304);
            this.ITI.Name = "ITI";
            this.ITI.Size = new System.Drawing.Size(41, 39);
            this.ITI.TabIndex = 2;
            this.ITI.Text = "ITI";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.textBox1.Location = new System.Drawing.Point(59, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Doaa Abdelhadi";
            // 
            // Pendulum_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ITI);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Display);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pendulum_display";
            this.Text = "Pendulum";
            this.Load += new System.EventHandler(this.Pendulum_display_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pendulum_display_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ITI;
        private System.Windows.Forms.TextBox textBox1;
    }
}

