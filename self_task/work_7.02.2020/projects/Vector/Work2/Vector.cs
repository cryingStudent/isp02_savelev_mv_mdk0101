using System;


namespace Work2
{
    class Vector
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value;}
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vector(double x, double y, double z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

      
        //длинна вектора
        public double Length()
        {
            double resultLen = 0;
            resultLen = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

            return resultLen;
        }

        //скалярное произведение векторов
        public double scalarProduct(Vector vec02)
        {
            double resultеScal = 0;
            resultеScal = (x * vec02.x) + (y * vec02.y) + (z * vec02.z);

            
            return resultеScal;
        }

      
        //метод вычисляющий векторное произведение с другим
        public Vector vectorProduct (Vector vec02)
        {

            Vector vec = new Vector((y * vec02.z - z * vec02.y), (z * vec02.x - x * vec02.z), (x * vec02.y - y * vec02.x));

            return vec;
        }

        public override string ToString()
        {
            return $"X:{X}, Y:{Y}, Z:{Z}";
        }


    }
}
