using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Address
    {
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Home { get; set; }
        public int ApartmentNumber { get; set; }
        public Address(int zipCode, string city, string street, int home, int apartmentNumber)
        {
            ZipCode = zipCode;
            City = city;
            Street = street;
            Home = home;
            ApartmentNumber = apartmentNumber;
        }
        public override string ToString()
        {
            return $"Почтовый индекс: {ZipCode} \nГород: {City} \nУлица: {Street} \nДом: {Home} \nКвартира: {ApartmentNumber}";
        }
    }
}
