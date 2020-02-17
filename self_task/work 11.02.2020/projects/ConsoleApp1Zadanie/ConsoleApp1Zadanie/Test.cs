using System;

namespace ConsoleApp1Zadanie
{
    class Test
    {
        public string Examinator { get; set; }

        public string Examiner { get; set; }

        public DateTime Date { get; set; }

        public int Estimation { get; set; }

        public Test(string examinator, string examiner, DateTime date, int estimation)
        {
            Examinator = examinator;
            Examiner = examiner;
            Date = date;
            Estimation = estimation;
        }

        public override string ToString()
        {
            return $"Examinator: {Examinator} \nExaminer: {Examiner} \nDate: {Date.ToLongDateString()} \nEstimation: {Estimation}";
        }
    }
}
