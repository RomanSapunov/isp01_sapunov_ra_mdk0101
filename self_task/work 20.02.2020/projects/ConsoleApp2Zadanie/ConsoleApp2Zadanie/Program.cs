using System;

namespace ConsoleApp2Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker01 = new Worker();
            worker01.SetName("Иван");
            worker01.SetAge(25);
            worker01.SetSalary(1000);

            Worker worker02 = new Worker();
            worker02.SetName("Вася");
            worker02.SetAge(26);
            worker02.SetSalary(2000);

            Console.WriteLine("Сумма зарплаты Ивана и Васи: " + (worker01.GetSalary() + worker02.GetSalary()));

            Console.ReadKey();
        }
    }
}
