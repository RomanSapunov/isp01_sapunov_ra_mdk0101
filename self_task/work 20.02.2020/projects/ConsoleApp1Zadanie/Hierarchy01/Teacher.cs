using System;
using System.Collections.Generic;

namespace Hierarchy01
{
    class Teacher : Person
    {
        private List<string> disciplines;
        private string countDisciplines;

        public Teacher(int age, string name, params string[] disciplines) : base(age, name)
        {
            this.disciplines = new List<string>(disciplines);
        }

        public void AddDiscipline(string discipline)
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(string discipline)
        {
            disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            foreach (var item in disciplines)
                countDisciplines += item + "; ";

            return $"Age: {age} \nName: {name} \nDisciplines: {countDisciplines}";
        }

        public override void Print()
        {
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Name: {name}");
            Console.Write($"Disciplines: ");
            foreach (var item in disciplines)
                Console.Write(item + "; ");
        }
    }
}
