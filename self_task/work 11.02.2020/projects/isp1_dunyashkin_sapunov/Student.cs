using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Student
    {
        public string Name { get; set; }
        public int Course { get; set; }
        readonly string Gender;

        public Student(string name, int course, string gender)
        {
            Name = name;
            Course = course;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Имя: {Name} \nПол: {Gender} \nКурс: {Course}";
        }

    }
}
