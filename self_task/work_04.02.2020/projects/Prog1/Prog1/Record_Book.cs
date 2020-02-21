using System;


namespace Prog1
{
    class Record_Book
    {

        private string nameExaminee;
        private string nameExaminer;
        private int mark;

        public string NameExaminee
        {
            get{ return nameExaminee; }
            set{ nameExaminee = value; }
        }

        public string NameExaminer
        {
            get { return nameExaminer; }
            set { nameExaminer = value; }
        }

        public int Mark
        {
            get { return mark; }
            set { mark = value;}
        }


        public override string ToString()
        { 
            return $"Экзаменуемый - {nameExaminee}, " +
                $"Экзаменатор-- {nameExaminer}, Оценка-- {mark}";
        }


    }
}
