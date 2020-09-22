
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inher
{
    internal class SaleMan :Emp
    {
        private String region;
        private int sales;
        private int pouns;

        public SaleMan()
        {
        }

        public SaleMan( string _name, int _salary, string _region, int _sales, int _pouns):base(_name,_salary)
        {
            region = _region;
            
            Name = _name;
            Sales = _sales;
            Pouns = _pouns;
            Salary = _salary + (_sales *_pouns);
            //Salary = _salary;

        }

        public string Region { get => region; set => region = value; }
        //public int Salary { get => salary; set => salary = value; }
        public int Sales { get => sales; set => sales = value; }
        public int Pouns { get => pouns; set => pouns = value; }

        /*public float CalSalary()
        {
            return (Sales * Pouns) + salary;


        }*/
    }
}
