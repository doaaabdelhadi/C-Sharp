using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher
{
    class Program
    {
        static void Main(string[] args)
        {

            Emp e = new Emp() { Id = 1, Name = "nj", Salary = 9000 };
            e.Display();
           Developer dev = new Developer("Ahm","AGH",12000) ;
            dev.Display();
            Console.WriteLine($"Project: {dev.Projet}");
           

            SaleMan sale = new SaleMan("Doff",22000,"Cairo",50, 100);
            
            sale.Display();
            Console.WriteLine($"Region: {sale.Region}");
           // Console.WriteLine(sale.CalSalary());







        }

    }
}
