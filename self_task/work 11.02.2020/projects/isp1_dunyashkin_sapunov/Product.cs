using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ExpirationDate { get; set; }

        public Product(string name, int quantity, double price, int expirationDate)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return $"Наименование: {Name} \nКоличество: {Quantity} \nСтоимость: {Price} \nСрок годности: {ExpirationDate} дней";
        }
    }
}
