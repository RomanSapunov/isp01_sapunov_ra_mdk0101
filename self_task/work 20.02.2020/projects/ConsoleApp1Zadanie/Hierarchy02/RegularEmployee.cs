namespace Hierarchy02
{
    class RegularEmployee : Employee
    {
        private float salary;
        private int bonus;

        public RegularEmployee(int id, string name, float salary, int bonus) : base(id, name)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public override string ToString()
        {
            return $"Id: {id} \nName: {name} \nSalary: {salary} \nBonus: {bonus}";
        }
    }
}
