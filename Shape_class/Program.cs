using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] sh_arr = new Shape[2];
            sh_arr[0] = new rectangle(12, 13);
            sh_arr[1] = new triangle(12, 13);
            
            float sum = 0;
            for (int i = 0; i < sh_arr.Length; i++)
            {
                Console.WriteLine($"calArea {i}: {sh_arr[i].CalArea()}");
                sum += sh_arr[i].CalArea();
            }

            Console.WriteLine($"sum: {sum}");

        }
    }
}
