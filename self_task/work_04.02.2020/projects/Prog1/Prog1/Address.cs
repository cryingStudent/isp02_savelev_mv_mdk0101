using System;


namespace Prog1
{
    class Address
    {
        private int index;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get { return index;  }
            set { index = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
            
        public string Street
        {
            get { return street;  }
            set { street = value; }
        }

        public int House
        {
            get { return house; }
            set { house = value;}
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public override string ToString()
        {
            return $"Почтовый индекс-- {index}, Город-- {city}, " +
                $"Улица-- {street}, Дом-- {house}, Квартира-- {apartment}";
        }
    }
}
