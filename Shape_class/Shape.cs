using System;

namespace pro
{
    abstract class Shape
    {
        protected int dim1;
        protected int dim2;

        public Shape()
        {
        }

        public Shape(int _dim1, int _dim2)
        {
            Dim1 = _dim1;
            Dim2 = _dim2;
        }

        public int Dim1 { get => dim1; set => dim1 = value; }
        public int Dim2 { get => dim2; set => dim2 = value; }

        public abstract float CalArea();
       
    }
}