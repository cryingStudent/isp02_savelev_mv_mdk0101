using System;

namespace Prog1
{
    class Student
    {
        private string name;
        private int course;
        public readonly string gender;

        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public Student(string gender)
        {
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Имя-- {name} Курс-- {course}, Пол-- {gender}"; 
        }



    }
}
