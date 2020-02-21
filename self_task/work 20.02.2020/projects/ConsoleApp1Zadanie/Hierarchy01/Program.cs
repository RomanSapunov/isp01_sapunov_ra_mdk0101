using System;

namespace Hierarchy01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[4];

            person[0] = new Student(18, "Смирнов Никита Александрович", 2, "ИСП-1");
            person[1] = new Student(16, "Суров Александр Александрович", 1, "ИСП-4");
            person[2] = new Teacher(23, "Коптев Никита Андреевич", "Информатика", "Математика");
            person[3] = new Teacher(21, "Житков Никита Артёмович", "ААС", "Компьютерные сети");

            foreach (var item in person)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
