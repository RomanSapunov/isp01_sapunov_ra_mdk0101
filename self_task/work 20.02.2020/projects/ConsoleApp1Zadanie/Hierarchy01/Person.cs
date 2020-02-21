using System;

namespace Hierarchy01
{
    class Person
    {
        protected int age;
        protected string name;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Age: {age} \nName: {name}";
        }

        public virtual void Print()
        {
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Name: {name}");
        }
    }
}
