using System;


namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector vector1 = new Vector(121, 441, 512);
            Vector vector2 = new Vector(11, 41, 52);

            Console.WriteLine($"Длина вектора-- ({vector1.Length()})");
            
            Console.WriteLine();
            Console.WriteLine($"Скалярное произведение векторов-- ({vector2.Length()})");
            
            Console.WriteLine();
            Console.WriteLine($"Векторное произведение с другим вектором-- " +
                $"({vector1.vectorProduct(vector2)})");      

            Console.WriteLine();
            Console.WriteLine($"Вектор 1-- ({vector1.ToString()})"); 

            Console.ReadKey();
        }
    }
}
