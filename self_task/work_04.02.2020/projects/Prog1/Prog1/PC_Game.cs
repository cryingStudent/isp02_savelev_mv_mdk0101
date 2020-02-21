using System;


namespace Prog1
{
    class PC_Game
    {
        private string name;
        private string firm;
        private int year;
        private string genre;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Firm
        {
            get { return firm; }
            set { firm = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }


        public override string ToString()
        {
            return $"Название игры-- {name}, Компания-- {firm}, " +
                $"Год издания-- {year}, Жанр-- {Genre}";
        }

    }
}
