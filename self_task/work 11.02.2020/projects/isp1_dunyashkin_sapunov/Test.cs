using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_dunyashkin_sapunov
{
    class Test
    {
        public string Examinator { get; set; }
        public string Examiner { get; set; }
        public string Date { get; set; }
        public int Estimation { get; set; }


        public Test(string examinator, string examiner, string date, int estimation)
        {
            Examinator = examinator;
            Examiner = examiner;
            Date = date;
            Estimation = estimation;
        }

        public override string ToString()
        {
            return $"ФИО экзаменуемого: {Examinator} \nФИО эказменатора: {Examiner} \nДата: {Date} \nОценка: {Estimation}";
        }
    }
}
