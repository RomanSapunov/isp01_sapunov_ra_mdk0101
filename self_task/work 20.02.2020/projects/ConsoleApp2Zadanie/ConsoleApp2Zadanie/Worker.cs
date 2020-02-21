using System;

namespace ConsoleApp2Zadanie
{
    class Worker : User
    {
        protected float salary;

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }

        public float GetSalary()
        {
            return salary;
        }
    }
}
