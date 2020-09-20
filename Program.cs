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
            //Tas
            D2Arrary();
            //Task3
            EmpShow();
            //F-Task
            MaxDis();




        }

        //F-Task
        public void MaxDis()
        {
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
                        //Console.WriteLine("---------");


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
            int[,] Arr2 = new int[2, 2];

            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"Plz enter numbers {i + 1}");
                    Arr2[i, j] = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("*************");
            //  int MaxArr2 = Arr2[0, 0], MinArr2 = Arr2[0, 0], SumArr2 = 0;
            int[] SumArr = new int[Arr2.GetLength(0)];
            
            for (int i=0; i < Arr2.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {
                    //Console.WriteLine(Arr2[i,j]);

                    sum += Arr2[i, j];
                }
                
                SumArr[i] = sum;
                Console.WriteLine($"Sum{i}: {sum}");


            }
        }
        
        /*for (int i = 0; i < Arr2.GetLength(0); i++)
        {

            Console.WriteLine(Arr2[i,i]);

        }
        for (int j = 0; j < Arr2.GetLength(); j++)
        {

            Console.WriteLine($"2D array: {Arr2[i, j] }");

            /* if (MaxArr2 < Arr2[i, j])
            {
                MaxArr2 = Arr2[i, j];
            }
            else if (MinArr2 > Arr2[i, j])
            {
                MinArr2 = Arr2[i, j];
            }
        }*/
        //Console.WriteLine($"Max of 2D array: {MaxArr2 }");
        //Console.WriteLine($"Min of 2D array: {MinArr2 }");
        //Console.WriteLine($"Sum of 2D array: {SumArr2 }");

        //task3
        struct Emp
        {
            private int Id;
            private string Name;
            private int Age;

            public void SetId(int _Id)
            {
                Id = _Id;
            }
            public int GetId()
            {
                return Id;
            }

            public void SetName(String _name)
            {
                Name = _name;
            }
            public String GetName()
            {
                return Name;
            }
            public void SetAge(int _age)
            {
                Age = _age;
            }
            public int GetAge()
            {
                return Age;
            }

            public void Print()
            {
                Console.WriteLine($"Id: {GetId()}");

                Console.WriteLine($"Name: {GetName()}");

                Console.WriteLine($"Age: {GetAge()}");
            }

        }

        //task4,5
        public void EmpShow()
        {
            Emp[] emp = new Emp[3];
            /*e1.SetId(1);
            e1.SetAge(11);
            e1.SetName("Am");*/
            //Console.WriteLine(e1.GetAge());
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].SetId(i + 1);
                Console.WriteLine("Plz enter your Name ");
                emp[i].SetName(Console.ReadLine());
                Console.WriteLine("Plz enter your Age ");
                emp[i].SetAge(int.Parse(Console.ReadLine()));

                emp[i].Print();

            }
           /* for (int i = 0; i < emp.Length; i++)
            {
                emp[i].Print();

            }*/
        }
       
        

    }
}
