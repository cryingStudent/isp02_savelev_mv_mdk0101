using System;


namespace Prog1
{
    class Product
    {
        private string nameProduct;
        private int quantityProduct;
        private int cost;
        private int[] shelfLife;

        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }

        public int QuantityProduct
        {
            get { return quantityProduct; }
            set { quantityProduct = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int[] ShelfLife
        {
            get { return shelfLife; }
            set { shelfLife = value; }
        }


        public override string ToString()
        {
            return $"Наименование-- {nameProduct}, Количество-- {quantityProduct}, " +
                $"Стоимость-- {cost}, Годен до-- {shelfLife[1]}.{shelfLife[2]}.{shelfLife[3]}";
        }





    }
}
