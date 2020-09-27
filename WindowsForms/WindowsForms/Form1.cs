using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 500);
            //List <Emp> lst = new List<Emp>();
            
            //lst.Add(new Emp() { Id = 3, Name = "Omar", Salary = 1300 });
            //lst.Add(new Emp() { Id = 3, Name = "Omar", Salary = 1300 });
            //lst.Add(new Emp() { Id = 3, Name = "Omar", Salary = 1300 });
            lst_Emp0.Items.Add(new Emp() { Age = 30, Name = "Omar", Salary = 1300 });
            lst_Emp0.Items.Add(new Emp() { Age = 25, Name = "Mohamed", Salary = 1500 });
            lst_Emp0.Items.Add(new Emp() { Age = 27, Name = "Ahmed", Salary = 1400 });
            //lst_Emp0.Items.Add("aeae");

        }
        private void lst_Emp0_SelectedIndexChanged(object sender, EventArgs e)
        {
              try
            {
                //this.Nametxt.Text = lst_Emp.SelectedItem.ToString();
                int index = lst_Emp0.SelectedIndex;
                Emp e1 = lst_Emp0.Items[index] as Emp;
                 this.BoxName0.Text = e1.Name;
                this.BoxAge.Text = e1.Age.ToString();
                 this.BoxSalary.Text = e1.Salary.ToString();

            }
            catch
            {

            }

            /*Emp e1 = lst_Emp0.Items[lst_Emp0.SelectedIndex] as Emp;
            if (e1 != null)
            {
                //MessageBox.Show(e1.ToString());
                this.BoxName0.Text = e1.Name;
                this.BoxAge.Text = e1.Age.ToString();
                this.BoxSalary.Text = e1.Salary.ToString();
                this.HelloMes.Text = $"Hello {this.BoxName0.Text}";

            }
            else
            {
                MessageBox.Show("Worng Data");
            }*/


        }

      

       
      

        private void Show_emp_lab_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
        
            int index = lst_Emp0.SelectedIndex;
            lst_Emp0.Items.RemoveAt(index);
            lst_Emp0.Items.Insert(index,new Emp(){ Age = int.Parse(BoxAge.Text), Name =BoxName0.Text, Salary = int.Parse(BoxSalary.Text) });

        
        }
            
            /*Emp e1 = lst_Emp0.Items[lst_Emp0.SelectedIndex] as Emp;
            int index = lst_Emp0.SelectedIndex;
            // Get the currently selected item in the ListBox.
           

            /* for (int i = lst_Emp0.Items.Count-1; i > -1; i--)
             {
                 {
                     lst_Emp0.Items.RemoveAt(i);
                 }

             }*/
            /*if (index > lst_Emp0.Items.Count - 1)
        {

            e1.Age = int.Parse(BoxAge.Text);
            e1.Name = this.BoxName0.Text;
            e1.Salary = int.Parse(BoxSalary.Text);
            lst_Emp0.Items.Remove(lst_Emp0.SelectedItem);


            lst_Emp0.Items.Insert(index, e1.ToString());
        }
        else
        {
            MessageBox.Show(e1.ToString());
        }*/



        

        private void Delete_Click(object sender, EventArgs e)
        {

            int index = lst_Emp0.SelectedIndex;
            lst_Emp0.Items.RemoveAt(index);
            
            


            


        }
    }
}
