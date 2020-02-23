using System;

namespace Hierarchy_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker worker1 = new Worker();
            Worker worker2 = new Worker();

            worker1.SetName("Иван");
            worker1.SetAge(25);
            worker1.SetSalary(1000);

            worker2.SetName("Вася");
            worker2.SetAge(26);
            worker2.SetSalary(2000);

            int SumOfMoney = 0;
            SumOfMoney = worker1.GetSalary() + worker2.GetSalary();


            Console.ReadKey();
        }
    }
}
