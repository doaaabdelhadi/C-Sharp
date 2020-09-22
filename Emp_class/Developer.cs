using System.Data;

namespace inher
{
    internal class Developer :Emp
    {
        private string projet;
       // private int id;
        

        //private int salary;

        public Developer()
        {
        }
        
        public Developer(string _project)
        {
            Projet = _project;
        }

       public Developer( string _name,string _project, int _salary):base(_name,_salary)
        {
            Projet = _project;
            //id =_id;
            Name=_name;
            Salary= _salary;

        }

        public string Projet { get => projet; set => projet = value; }
       //public int Salary { get => salary; set => salary = value; }
        /*public override float cal_salary ()
        {
            return salary;
        
        }*/
      
    }
}