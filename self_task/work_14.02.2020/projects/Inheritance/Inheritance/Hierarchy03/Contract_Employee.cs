using System;


namespace Inheritance.Hierarchy03
{
    class Contract_Employee : Employee
    {
        public float Pay_per_hour { get; set; }
        public string Contract_period { get; set; }

        public Contract_Employee(float pay_per_hour, string contract_period, int ID, string Name, DateTime UnploadDate)
            : base(ID, Name, UnploadDate)
        {
            Pay_per_hour = pay_per_hour;
            Contract_period = contract_period;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Оплата за час-- {Pay_per_hour}, Контрактный период-- {Contract_period}";
        }




    }
}
