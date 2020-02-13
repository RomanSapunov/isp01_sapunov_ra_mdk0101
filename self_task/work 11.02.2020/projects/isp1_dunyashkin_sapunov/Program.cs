using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student
            Student student = new Student("Иван", 2, "Мужской");
            Console.WriteLine(student);

            Console.WriteLine();

            //Employee
            Employee employee = new Employee("Андрей", "Уборщик", 7);
            Console.WriteLine(employee);

            Console.WriteLine();

            //Workshop
            Workshop workshop = new Workshop("193QP3", 45);
            Console.WriteLine(workshop);

            Console.WriteLine();

            //Book
            Book book = new Book("Колобок", 50.50, "Петр Петров Петрович", "Игорь Игоревичев Игоревич");
            Console.WriteLine(book);

            Console.WriteLine();

            //Test
            Test test = new Test("Сергей Сергевьич Сергеев", "Петр Петров Петрович", new DateTime(2012, 5, 1), 5);
            Console.WriteLine(test);

            Console.WriteLine();

            //Address
            Address address = new Address(54953, "Волжский", "Карла-Маркса", 23, 12);
            Console.WriteLine(address);

            Console.WriteLine();

            //Product
            Product product = new Product("Сок", 50, 25, 90);
            Console.WriteLine(product);

            Console.WriteLine();

            //TrainingGroup
            TrainingGroup trainingGroup = new TrainingGroup("295423", 20, 2018, "ATP-75");
            Console.WriteLine(trainingGroup);

            Console.WriteLine();

            //MonetaryDenomination
            MonetaryDenomination monetaryDenomination = new MonetaryDenomination("HE 54237", 200, "Двести");
            Console.WriteLine(monetaryDenomination);

            Console.WriteLine();

            //ComputerGame
            ComputerGame computerGame = new ComputerGame("STALKER 2", "GSC Game World", 2021, "Open World");
            Console.WriteLine(computerGame);

            Console.ReadKey();
        }
    }
}
