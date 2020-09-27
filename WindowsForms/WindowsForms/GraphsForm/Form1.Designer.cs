namespace GraphsForm
{
    partial class Ball_play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ball_play));
            this.But_Control = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Red_conuter = new System.Windows.Forms.NumericUpDown();
            this.Green_count = new System.Windows.Forms.NumericUpDown();
            this.Bule_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Red_conuter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bule_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // But_Control
            // 
            this.But_Control.BackColor = System.Drawing.Color.OrangeRed;
            this.But_Control.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Control.Location = new System.Drawing.Point(460, 225);
            this.But_Control.Name = "But_Control";
            this.But_Control.Size = new System.Drawing.Size(114, 52);
            this.But_Control.TabIndex = 0;
            this.But_Control.Text = "Start";
            this.But_Control.UseVisualStyleBackColor = false;
            this.But_Control.Click += new System.EventHandler(this.But_Control_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Red_conuter
            // 
            this.Red_conuter.BackColor = System.Drawing.Color.Red;
            this.Red_conuter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Red_conuter.ForeColor = System.Drawing.Color.Yellow;
            this.Red_conuter.Location = new System.Drawing.Point(15, 251);
            this.Red_conuter.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red_conuter.Name = "Red_conuter";
            this.Red_conuter.Size = new System.Drawing.Size(85, 26);
            this.Red_conuter.TabIndex = 1;
            this.Red_conuter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Red_conuter.ValueChanged += new System.EventHandler(this.Red_conuter_ValueChanged);
            // 
            // Green_count
            // 
            this.Green_count.BackColor = System.Drawing.Color.Green;
            this.Green_count.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Green_count.ForeColor = System.Drawing.Color.Yellow;
            this.Green_count.Location = new System.Drawing.Point(121, 251);
            this.Green_count.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green_count.Name = "Green_count";
            this.Green_count.Size = new System.Drawing.Size(85, 26);
            this.Green_count.TabIndex = 2;
            this.Green_count.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Bule_count
            // 
            this.Bule_count.BackColor = System.Drawing.Color.Blue;
            this.Bule_count.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bule_count.ForeColor = System.Drawing.Color.Yellow;
            this.Bule_count.Location = new System.Drawing.Point(226, 251);
            this.Bule_count.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Bule_count.Name = "Bule_count";
            this.Bule_count.Size = new System.Drawing.Size(85, 26);
            this.Bule_count.TabIndex = 3;
            this.Bule_count.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set RGB Color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ball_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bule_count);
            this.Controls.Add(this.Green_count);
            this.Controls.Add(this.Red_conuter);
            this.Controls.Add(this.But_Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ball_play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ball_play";
            this.Load += new System.EventHandler(this.Ball_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ball_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Red_conuter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bule_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Control;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Red_conuter;
        private System.Windows.Forms.NumericUpDown Green_count;
        private System.Windows.Forms.NumericUpDown Bule_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

