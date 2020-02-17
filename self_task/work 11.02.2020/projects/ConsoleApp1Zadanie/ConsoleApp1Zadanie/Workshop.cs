using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Zadanie
{
    class Workshop
    {
        public string StringCipher { get; set; }

        public int NumberOfEmployees { get; set; }

        public Workshop(string stringCipher, int numberOfEmployees)
        {
            StringCipher = stringCipher;
            NumberOfEmployees = numberOfEmployees;
        }

        public override string ToString()
        {
            return $"Строковый шифр: {StringCipher} \nКоличество служащих: {NumberOfEmployees}";
        }
    }
}
