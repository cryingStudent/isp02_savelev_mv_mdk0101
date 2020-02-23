using System;

namespace Hierarchy_2
{
    class User
    {
        protected string name;
        protected int age;


        //name
        public void SetName(string value)
        {
            name = value;
        }

        public string GetName()
        {
            return name;
        }

        //age
        public void SetAge(int value)
        {
           age = value;
        }

        public int GetAge()
        {
            return age;
        }



    }
}
