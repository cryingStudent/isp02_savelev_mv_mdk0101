using System;


namespace Inheritance.Hierarchy01
{
    class Teacher : Person
    {

        private string disciplines;

        public Teacher(string name, int age, string disciplines)
           : base(age, name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(string disciplines)
        {
            this.disciplines = disciplines;
        }

        public void RemoveDiscipline()
        {
            disciplines = null;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Дисциплин-- {disciplines}";
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

    }
}
