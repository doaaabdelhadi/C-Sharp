using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //task I
            Console.WriteLine(calce(10, 2, '+'));
             Console.WriteLine(calce(10, 2, '-'));
             Console.WriteLine(calce(10, 2, '*'));
             Console.WriteLine(calce(10, 2, '/'));
             Console.WriteLine(calce(2, 10, '%'));
            // Task II

            Console.WriteLine(Expon(2, 3));
            Console.WriteLine(Expon(5, 2));
            // Task III
            Console.WriteLine(factorial(6));
            Console.WriteLine(factorial(5));
            
            //Task IIII 
            int[] arr = new int[] {1, 13, 2}; 
             Console.WriteLine(SumNum(arr));
             Console.WriteLine(SumNum(12,344,44,55));

            //Task IIIII
            // create obj1
            points obj1 = new points(2,3 ,4);
            // print obj1
            obj1.Display();
            // create obj2
            points obj2 = new points(2, 3, 5);
            // check obj1 == obj2 // if the valuses are not equal == False...
            Console.WriteLine(obj1 == obj2);
            //
            obj1 = obj2;
            obj1.Display();
            obj2.Display();
            // check obj1 == obj2 // if the valuses are  equal = True...
            Console.WriteLine(obj1 == obj2);
            obj2 = new points(21, 13, 23);
            obj1.Display();
            obj2.Display();
            Console.WriteLine(obj1 == obj2);


        }

        

        static public int SumNum(params int[] arr)
        {
            int sum = 0;
            foreach (int items in arr)
            {
                sum += items;
            }
            return sum;

        }

        static public int factorial (int x)
        {
            int fa=1;
            for (int i = 1; i <= x; i++)
            {
                fa *= i;
            }
                return fa;
        }
        
        static public int Expon(int x, int y)
        {
            int ex = 1;
            for (int i = 0; i < y;i++)
            {
                ex *= x;
               
            }
            return ex;
        }
        static public int calce (int x, int y, char op)
        {

            switch (op)
            {
                case '+':
                   
                    return x + y;

                case '-':
                    return x - y;
                   
                case '*':
                    return x * y;
                 
                case '/':
                    return(x / y);
                case '%':
                    return(x % y);
                default:
                    // code block
                    return 0;

            }
            /* if (op == '+')
             {
                 return x + y;
             }
             else if (op == '-')
             {
                 return x - y;
             }
             else if (op == '*')
             {
                 return x * y;
             }
             else if (op =='/')
             {
                 return x / y;
             }
             else if (op == '%')
             {
                 return x % y;
             } */
           // return (0);
        }
    }
}
