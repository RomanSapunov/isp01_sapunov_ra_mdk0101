using System;

namespace ConsoleApp1Zadanie
{
    class Book
    {
        public string Title { get; set; }

        public string[] Authors { get; set; }

        private string fioTemp;

        public double Price { get; set; }

        public Book(string title, double price, params string[] authors)
        {
            Title = title;
            Authors = authors;
            Price = price;
        }

        public override string ToString()
        {
            foreach (var fio in Authors)
            {
                fioTemp += fio + "; ";
            }
            return $"Title: {Title} \nPrice: {Price} \nAuthors: {fioTemp}";
        }
    }
}
