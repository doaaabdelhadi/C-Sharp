using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_task1
{
    class Program
    {
        static void Main(string[] args)
        {


            //task1
            OneDimetion();
            //Task2
            D2Arrary();
            //Task3
            EmpShow();
            //F-Task
            MaxDis();




        }

        //F-Task
        public void MaxDis()
        {
            //
            int[] arr = new int[] { 1, 3, 2, 1, 4, 3, 1, 2, 1 };
            int Max_dis = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        //Console.WriteLine($"({i}, {j})");
                        int dis = (j - i);

                        //Console.WriteLine($"({arr[i]}, {arr[j]})");

                        //Console.WriteLine(dis);
                        if (Max_dis < dis)
                        {
                            Max_dis = dis;
                        }
                       


                    }





                }
            }
            Console.WriteLine($"Max_dis: {Max_dis}");
        }
        //task1
        public void OneDimetion()
        {
            int[] arr1 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Plz enter degree {i + 1}");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"degrees of students: { arr1[i]}");
            }

            int MaxArr1 = arr1[0];
            int MinArr1 = arr1[0];
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (MaxArr1 < arr1[i])
                {
                    MaxArr1 = arr1[i];
                }
                else if (MinArr1 > arr1[i])
                {
                    MinArr1 = arr1[i];
                }

                sum += arr1[i];


            }
            Console.WriteLine($"Max of degrees {MaxArr1}");
            Console.WriteLine($"Min of degrees {MinArr1}");
            Console.WriteLine($"Sum of degrees {sum}");
        }
        //task2
        static void D2Arrary()
        {
            //first part
            // imple 2D arrray
            //define array
            int[,] Arr2 = new int[2, 2];
            //set values for array
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"Plz enter numbers {i + 1}");
                    Arr2[i, j] = int.Parse(Console.ReadLine());

                }

            }
            //Second part 
            // For return Sum of every col
            //arr to save sum 
            int[] SumArr = new int[Arr2.GetLength(0)];
            
            for (int i=0; i < Arr2.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {

                    sum += Arr2[i, j];
                }
                
                SumArr[i] = sum;
                Console.WriteLine($"Sum{i}: {sum}");


            }
        }
        

        //task3
        struct Emp
        {
            // define the attur
            private int Id;
            private string Name;
            private int Age;
            // function for setting value for Id
            public void SetId(int _Id)
            {
                Id = _Id;
            }
             // function for getting value for Id
            public int GetId()
            {
                return Id;
            }
             // function for setting value for Name

            public void SetName(String _name)
            {
                Name = _name;
            }
             // function for getting value for Name
            public String GetName()
            {
                return Name;
            }
             // function for setting value for Age
            public void SetAge(int _age)
            {
                Age = _age;
            }
             // function for Getting value for Id
            public int GetAge()
            {
                return Age;
            }
            // function to print the attru
            public void Print()
            {
                Console.WriteLine($"Id of emp: {GetId()}");

                Console.WriteLine($"Name of emp: {GetName()}");

                Console.WriteLine($"Age of emp: {GetAge()}");
            }

        }

        //task4,5
        public void EmpShow()
        {
            Emp[] emp = new Emp[3];
            //loop to inst 3 element of Emp
            for (int i = 0; i < emp.Length; i++)
            {
                //set id as defult increase by 1
                emp[i].SetId(i + 1);
                Console.WriteLine("Plz enter your Name ");
                //set the name value for name
                emp[i].SetName(Console.ReadLine());
                Console.WriteLine("Plz enter your Age ");
                //set the name value for Age
                emp[i].SetAge(int.Parse(Console.ReadLine()));
                //print elements
                emp[i].Print();

            }
        
        }
       
        

    }
}
