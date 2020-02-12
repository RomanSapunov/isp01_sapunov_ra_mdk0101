using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
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
            return $"Серия и номер: {SeriesAndNumber} \nНаминал: {Naminal} \nНаминал прописью: {NaminalString}";
        }
    }
}
