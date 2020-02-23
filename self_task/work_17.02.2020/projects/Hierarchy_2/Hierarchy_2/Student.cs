using System;


namespace Hierarchy_2
{
    class Student : User
    {
        private int scholarship;
        private int course;


        //scholarship
        public void SetScholarship(int value)
        {
            scholarship = value;
        }

        public int GetScholarship()
        {
            return scholarship;
        }

        //course
        public void SetCourse(int value)
        {
            course = value;
        }

        public int GetCourse()
        {
            return course;
        }

    }
}
