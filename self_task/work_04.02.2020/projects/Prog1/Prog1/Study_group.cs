using System;

namespace Prog1
{
    class Study_group
    {

        private int cipher;
        private string specialty;
        private int quantity;
        private int yearOfFormation;

        public int Сipher
        {
            get { return cipher; }
            set { cipher = value; }
        }

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int YearOfFormation
        {
            get { return yearOfFormation; }
            set { yearOfFormation = value; }
        }

        public override string ToString()
        {
            return $"Шифр-- {cipher}, Специальность-- {specialty}, Количество студентов-- {quantity}, Год формирования-- {yearOfFormation} год.";
        }


    }
}
