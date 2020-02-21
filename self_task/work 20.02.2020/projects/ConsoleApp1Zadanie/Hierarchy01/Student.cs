using System;

namespace Hierarchy01
{
    class Student : Person
    {
        private int course;
        private string group;

        public Student(int age, string name, int course, string group) : base(age, name)
        {
            this.course = course;
            this.group = group;
        }

        public void NextCourse()
        {
            course++;
        }

        public override string ToString()
        {
            return $"Age: {age} \nName: {name} \nCourse: {course} \nGroup: {group}";
        }

        public override void Print()
        {
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Group: {group}");
        }
    }
}
