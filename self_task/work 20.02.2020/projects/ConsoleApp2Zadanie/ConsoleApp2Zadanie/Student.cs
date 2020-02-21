using System;

namespace ConsoleApp2Zadanie
{
    class Student : User
    {
        private double grants;
        private int course;

        public void SetGrants(double grants)
        {
            this.grants = grants;
        }

        public double GetGrants()
        {
            return grants;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }

        public int GetCourse()
        {
            return course;
        }
    }
}
