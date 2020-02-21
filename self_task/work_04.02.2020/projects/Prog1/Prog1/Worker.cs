using System;


namespace Prog1
{
    class Worker
    {

        private string name;
        private string profession;
        private int skill;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public int Skill
        {
            get { return skill;  }
            set { skill = value; }
        }

        public override string ToString()
        {
            return $"Имя-- {name}-- Профессия {profession}, " +
                $"Рабочий стаж-- {skill} лет";
        }



    }
}
