using System;


namespace Inheritance.Hierarchy03
{
    class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }


        public Employee(int id, string name, DateTime uploadDate)
        {
            ID = id;
            Name = name;
            UploadDate = uploadDate;
        }

        public override string ToString()
        {
            return $"Номер сотрудника-- {ID}, ФИО сотрудника-- {Name}, Дата-- {UploadDate}";
        }

    }
}
