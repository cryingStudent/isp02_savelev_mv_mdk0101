using System;
using Inheritance.Hierarchy01;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Роганов Святослав Савельевич", 17, 2, "ИСП-2");
            Student student2 = new Student("Муркин Ян Мирославич", 16, 1, "ЭВТ-67");
            Teacher teacher1 = new Teacher("Шишкин Гордей Маркович", 34, "Психология");
            Teacher teacher2 = new Teacher("Рагозина Ангелина Мухамедовна", 59, "Физика");

            Person[] Hierar01 = new Person[4];
            Hierar01[0] = student1;
            Hierar01[1] = student2;
            Hierar01[2] = teacher1;
            Hierar01[3] = teacher2;

            foreach(Person value in Hierar01)
            {
                Console.WriteLine();
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
