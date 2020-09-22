
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inher
{
    internal class Emp
    {
			protected int id;
			protected String name;
			protected int salary;
			string project;

			public Emp()
			{
			}
			public Emp(String _name, int _salary)
			{
				name = _name;
				salary = _salary;
				


			}

			public Emp(int _id, String _name, int _salary)
			{
				id = _id;
				name = _name;
				salary = _salary;

			}
		public virtual float cal_salary ()
        {
            return salary;
        
        }

    
        public int Id { get => id; set => id = value; }
			public String Name { get => name; set => name = value; }
			public int Salary { get => salary; set => salary = value; }

			
		//public virtual float CalSalary() {return 0;}
		public void Display() => Console.WriteLine($"ID: {id}, Name: {name}, Salary: {cal_salary()}");
		
	}
	
}