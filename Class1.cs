using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class points
    {
        private int x;
        private int y;
        private int z;
        static private int counter;
        public points(int _x, int _y , int _z)
        {
            x = _x;
            y = _y;
            z = _z;
            counter +=1 ;
        }
        public int Counter
        {
            set { counter = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    
        public int Z
        {
        get { return z; }
        set { z = value; }
        }

        public void Display()
        {
            Console.WriteLine($"X:{x},Y: {y},Z: {z}, Counter:{counter}");
        }
}
}

