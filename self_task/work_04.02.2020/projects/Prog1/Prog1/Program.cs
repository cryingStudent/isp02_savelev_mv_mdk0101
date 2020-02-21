using System;


namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {

            char line = '_';

            //студент
            Console.WriteLine(new string(line, 120));
            Console.WriteLine("Студент:");
            Student Alice = new Student("Женский");

            Alice.Name = "Алиса";
            Alice.Course = 3;

            Console.WriteLine(Alice.ToString());
            Console.WriteLine(new string (line, 120));

            //служащий
            Console.WriteLine();
            Console.WriteLine("Служащий:");
            Worker worker = new Worker();

            worker.Name = "Михаил";
            worker.Profession = "Слесарь";
            worker.Skill = 25;

            Console.WriteLine(worker.ToString());
            Console.WriteLine(new string(line, 120));

            //цех 
            Console.WriteLine();
            Console.WriteLine("Цех:");
            Shop shop = new Shop();

            shop.Сipher = "GTTHIDHTEYTR";
            shop.Workers = 42;

            Console.WriteLine(shop.ToString());
            Console.WriteLine(new string(line, 120));

            //Книга
            Console.WriteLine();
            Console.WriteLine("Книжный магазин:");
            Book book = new Book();

                book.Heading = "Язык программирования C# и платформы .NET";

                book.Authors = new string[3];
                book.Authors[1] = "Эндрю Троелсен";
                book.Authors[2] = "Филипп Джепикс";
                book.Price = 4800.0;

            Console.WriteLine(book.ToString());
            Console.WriteLine(new string(line, 120));

            //Зачёт
            Console.WriteLine();
            Console.WriteLine("Зачёт:");
            Record_Book record_Book = new Record_Book();
            
            record_Book.NameExaminee = "Виноградов Алексей Викторович";
            record_Book.NameExaminer = "Виктор Генадьевич Кульков";
            record_Book.Mark = 4;

            Console.WriteLine(record_Book.ToString());
            Console.WriteLine(new string(line, 120));

            //Адрес
            Console.WriteLine();
            Console.WriteLine("Адрес: ");
            Address address = new Address();
           
            address.Index = 237632;
            address.City = "Волгоград";
            address.Street = "Пушкина";
            address.House = 21;
            address.Apartment = 5;

            Console.WriteLine(address.ToString());
            Console.WriteLine(new string(line, 120));

            //товар
            Console.WriteLine();
            Console.WriteLine("Товар:");
            Product product = new Product();
          
            product.NameProduct = "Сода";
            product.QuantityProduct = 15;
            product.Cost = 30;
                product.ShelfLife = new int[5];
                product.ShelfLife[1] = 12;
                product.ShelfLife[2] = 06;
                product.ShelfLife[3] = 3012;

            Console.WriteLine(product.ToString());
            Console.WriteLine(new string(line, 120));

            //Учебная группа
            Console.WriteLine();
            Console.WriteLine("Учебная группа:");
            Study_group study_group = new Study_group();
            
            study_group.Сipher = 1253254;
            study_group.Specialty = "Повар кондитер";
            study_group.Quantity = 24;
            study_group.YearOfFormation = 2010;
            
            Console.WriteLine(study_group.ToString());
            Console.WriteLine(new string(line, 120));

            //Денежная купюра
            Console.WriteLine();
            Console.WriteLine("Денежная купюра:");
            Notes notes = new Notes();
            notes.SerialAndNumber = "ЯЭ 1167761";
            notes.Denomination = 100;
            notes.DenominationToString = "Сто";
            Console.WriteLine(notes.ToString());
            Console.WriteLine(new string(line, 120));

            //Компьютерная игра
            Console.WriteLine();
            Console.WriteLine("Компьютерная игра:");
            PC_Game pc_game = new PC_Game();
            pc_game.Name = "Warcraft 3";
            pc_game.Firm = "Blizzard";
            pc_game.Year = 2002;
            pc_game.Genre = "стратегия";

            Console.WriteLine(pc_game.ToString());
            Console.WriteLine(new string(line, 120));

            Console.ReadKey();

        }
    }
}
