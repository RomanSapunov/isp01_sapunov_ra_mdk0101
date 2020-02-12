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
            Console.WriteLine(student.ToString());

            //Employee
            Employee employee = new Employee("Иван", "Оффицер", 11);
            Console.WriteLine(employee.ToString());

            //Workshop
            Workshop workshop = new Workshop("193QP39403", 45);
            Console.WriteLine(workshop.ToString());

            //Book
            Book book = new Book("Колобок", 50.50, "Петр Петров Петрович", "Игорь Игоревичев Игоревич");
            Console.WriteLine(book.ToString());

            //Test
            Test test = new Test("Сергей Сергевьич Сергеев", "Петр Петров Петрович", "15.01.2012", 5);
            Console.WriteLine(test.ToString());

            //Address
            Address address = new Address(54953, "Волжский", "Карла-Маркса", 23, 12);
            Console.WriteLine(address.ToString());

            //Product
            Product product = new Product("Сок", 50, 25, 90);
            Console.WriteLine(product.ToString());

            //TrainingGroup
            TrainingGroup trainingGroup = new TrainingGroup("295423", 20, 2018, "ATP-75");
            Console.WriteLine(trainingGroup.ToString());

            //MonetaryDenomination
            MonetaryDenomination monetaryDenomination = new MonetaryDenomination("HE 54237", 200, "Двести");
            Console.WriteLine(monetaryDenomination.ToString());

            //ComputerGame
            ComputerGame computerGame = new ComputerGame("STALKER 2", "GSC Game World", 2021, "Open World");
            Console.WriteLine(computerGame.ToString());
           
            Console.ReadKey();
        }
    }
}
