using System;

namespace Inheritance.Hierarchy03
{
    class Regular_Employee : Employee
    {
        public float Salary { get; set; }
        public int Bonus { get; set; }

        public Regular_Employee(float salary, int bonus, int ID, string Name, DateTime UnploadDate)
            : base(ID, Name, UnploadDate)
        {
            Salary = salary;
            Bonus = bonus;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Зарплата-- {Salary}, Премия-- {Bonus}";
        }

    }
}
