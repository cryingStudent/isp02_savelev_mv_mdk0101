using System;


namespace Hierarchy_2
{
    class Worker: User
    {
        private int salary;

        public void SetSalary(int value)
        {
            salary = value;
        }

        public int GetSalary()
        {
            return salary;
        }
    }
}
