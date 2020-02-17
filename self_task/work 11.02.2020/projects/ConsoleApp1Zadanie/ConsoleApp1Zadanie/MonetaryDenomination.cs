using System;

namespace ConsoleApp1Zadanie
{
    class MonetaryDenomination
    {
        public string SeriesAndNumber { get; set; }

        public int Naminal { get; set; }

        public string NaminalString { get; set; }

        public MonetaryDenomination(string seriesAndNumber, int naminal, string naminalString)
        {
            SeriesAndNumber = seriesAndNumber;
            Naminal = naminal;
            NaminalString = naminalString;
        }

        public override string ToString()
        {
            return $"Series And Number: {SeriesAndNumber} \nNaminal: {Naminal} \nNaminal String: {NaminalString}";
        }
    }
}
