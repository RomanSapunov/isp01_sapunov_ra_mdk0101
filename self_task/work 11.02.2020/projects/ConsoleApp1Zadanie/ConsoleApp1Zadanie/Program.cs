using System;

namespace ConsoleApp1Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Иван", 2, "Мужской");
            Console.WriteLine(student);
            Console.WriteLine();

            Employee employee = new Employee("Андрей", "Уборщик", 7);
            Console.WriteLine(employee);
            Console.WriteLine();

            Workshop workshop = new Workshop("193QP3", 45);
            Console.WriteLine(workshop);
            Console.WriteLine();

            Book book = new Book("Колобок", 50.50, "Петр Петров Петрович", "Игорь Игоревичев Игоревич");
            Console.WriteLine(book);
            Console.WriteLine();

            Test test = new Test("Сергей Сергевьич Сергеев", "Петр Петров Петрович", new DateTime(2012, 5, 1), 5);
            Console.WriteLine(test);
            Console.WriteLine();

            Address address = new Address(54953, "Волжский", "Карла-Маркса", 23, 12);
            Console.WriteLine(address);
            Console.WriteLine();

            Product product = new Product("Сок", 50, 24.50, 90);
            Console.WriteLine(product);
            Console.WriteLine();

            TrainingGroup trainingGroup = new TrainingGroup("09.02.07", 10, 2018, "ИСП-1");
            Console.WriteLine(trainingGroup);
            Console.WriteLine();

            MonetaryDenomination monetaryDenomination = new MonetaryDenomination("HE 54237", 200, "Двести");
            Console.WriteLine(monetaryDenomination);
            Console.WriteLine();

            ComputerGame computerGame = new ComputerGame("STALKER 2", "GSC Game World", 2021, "Open World");
            Console.WriteLine(computerGame);

            Console.ReadKey();
        }
    }
}
