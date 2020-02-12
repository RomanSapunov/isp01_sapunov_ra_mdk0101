using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkingExperience { get; set; }

        public Employee(string name, string profession, int workingExperience)
        {
            Name = name;
            Profession = profession;
            WorkingExperience = workingExperience;
        }

        public override string ToString()
        {
            return $"Имя: {Name} \nПрофессия: {Profession} \nРабочий стаж: {WorkingExperience}";
        }
    }
}
