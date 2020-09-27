

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsForms
{
    internal class Emp
    {
		protected int age;
		protected String name;
		protected int salary;

		public Emp()
		{
		}
		public Emp(String _name, int _salary)
		{
			name = _name;
			salary = _salary;



		}

		public Emp(int _age, String _name, int _salary)
		{
			age = _age;
			name = _name;
			salary = _salary;

		}

        public override string ToString()
        {
            return $" {Name}, {Salary}, {Age}" ;
        }

        public int Age { get => age; set => age = value; }
		public String Name { get => name; set => name = value; }
		public int Salary { get => salary; set => salary = value; }

        internal Emp GetItem(int selectedIndex)
        {
            throw new NotImplementedException();
        }


        //public virtual float CalSalary() {return 0;}
        //public void Display() => Console.WriteLine($"ID: {id}, Name: {name}");
    }
}