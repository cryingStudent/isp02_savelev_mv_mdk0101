using System;

namespace Prog1
{
    class Book
    {

        private string heading;
        private string[] authors;
        private double price;
        
        public string Heading
        {
            get { return heading; }
            set { heading = value; }
        }

        public string[] Authors
        {
            get { return authors; }
            set { authors = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

                        
        public override string ToString()
        {
            return $"Название книги-- {heading}, Авторы-- {authors[1]}, " +
                $"{authors[2]}, Цена-- {price} руб.";
        }
        
    }
}
