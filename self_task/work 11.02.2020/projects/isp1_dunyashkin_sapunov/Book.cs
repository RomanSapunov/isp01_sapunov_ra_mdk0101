using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        private string fioTemp;
        public double Price { get; set; }

        public Book (string title, double price, params string[] authors)
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

            return $"Название: {Title} \nСтоимость: {Price} \nСписок авторов: {fioTemp}";
        }
    }
}
