using System;

namespace ConsoleApp1Zadanie
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
            return $"Name: {Name} \nGender: {Gender} \nCourse: {Course}";
        }
    }
}
