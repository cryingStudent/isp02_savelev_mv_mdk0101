using System;


namespace Prog1
{
    class Shop
    {

        private string cipher;
        private int workers;


        public string Сipher
        {
            get { return cipher; }
            set { cipher = value; }
        }


        public int Workers
        {
            get { return workers;  }
            set { workers = value; }
        }



        public override string ToString()
        {
            return $"Строковый шифр-- {cipher}, " +
                $"Количество работников-- {workers}";
        }



    }
}
