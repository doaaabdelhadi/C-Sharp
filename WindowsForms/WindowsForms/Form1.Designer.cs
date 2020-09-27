namespace WindowsForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BoxSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Emp0 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_emp_lab = new System.Windows.Forms.Label();
            this.BoxAge = new System.Windows.Forms.TextBox();
            this.BoxName0 = new System.Windows.Forms.TextBox();
            this.HelloMes = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxSalary
            // 
            resources.ApplyResources(this.BoxSalary, "BoxSalary");
            this.BoxSalary.Name = "BoxSalary";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lst_Emp0
            // 
            this.lst_Emp0.FormattingEnabled = true;
            resources.ApplyResources(this.lst_Emp0, "lst_Emp0");
            this.lst_Emp0.Name = "lst_Emp0";
            this.lst_Emp0.SelectedIndexChanged += new System.EventHandler(this.lst_Emp0_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Show_emp_lab
            // 
            resources.ApplyResources(this.Show_emp_lab, "Show_emp_lab");
            this.Show_emp_lab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Show_emp_lab.Name = "Show_emp_lab";
            this.Show_emp_lab.Click += new System.EventHandler(this.Show_emp_lab_Click);
            // 
            // BoxAge
            // 
            resources.ApplyResources(this.BoxAge, "BoxAge");
            this.BoxAge.Name = "BoxAge";
            // 
            // BoxName0
            // 
            resources.ApplyResources(this.BoxName0, "BoxName0");
            this.BoxName0.Name = "BoxName0";
            // 
            // HelloMes
            // 
            resources.ApplyResources(this.HelloMes, "HelloMes");
            this.HelloMes.BackColor = System.Drawing.Color.Coral;
            this.HelloMes.ForeColor = System.Drawing.Color.Cornsilk;
            this.HelloMes.Name = "HelloMes";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Chartreuse;
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.HelloMes);
            this.Controls.Add(this.BoxName0);
            this.Controls.Add(this.BoxAge);
            this.Controls.Add(this.Show_emp_lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Emp0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxSalary);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoxSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Emp0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Show_emp_lab;
        private System.Windows.Forms.TextBox BoxAge;
        private System.Windows.Forms.TextBox BoxName0;
        private System.Windows.Forms.Label HelloMes;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
    }
}

