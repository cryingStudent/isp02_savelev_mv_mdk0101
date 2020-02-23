using System;


namespace Hierarchy_2
{
    class Driver: Worker
    {
        //в задаче сказано, сделать только поля, но как я понял нужны ещё методы get и set
        
        private DateTime drivingExperience;
        private char drivingСategory;

        //drivingExperience
        public void SetDrivingExperience(DateTime value)
        {
            drivingExperience = value;
        }

        public DateTime GetDrivingExperience()
        {
            return drivingExperience;
        }

        //drivingСategory
        public void SetDrivingСategory(char value)
        {
            drivingСategory = value;
        }

        public char GetDrivingСategory()
        {
            return drivingСategory;
        }


    }
}
