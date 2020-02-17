using System;

namespace ConsoleApp1Zadanie
{
    class Address
    {
        public int Zip { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int Home { get; set; }

        public int ApartmentNumber { get; set; }

        public Address(int zip, string city, string street, int home, int apartmentNumber)
        {
            Zip = zip;
            City = city;
            Street = street;
            Home = home;
            ApartmentNumber = apartmentNumber;
        }

        public override string ToString()
        {
            return $"Zip Code: {Zip} \nCity: {City} \nStreet: {Street} \nHome: {Home} \nApartmentNumber: {ApartmentNumber}";
        }
    }
}
