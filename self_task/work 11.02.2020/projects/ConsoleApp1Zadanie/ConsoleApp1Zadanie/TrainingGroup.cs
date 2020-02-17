﻿using System;

namespace ConsoleApp1Zadanie
{
    class TrainingGroup
    {
        public string Сipher { get; set; }

        public int NumberOfStudents { get; set; }

        public int YearOfFormation { get; set; }

        public string Specialty { get; set; }

        public TrainingGroup(string cipher, int numberOfStudents, int yearOfFormation, string specialty)
        {
            Сipher = cipher;
            NumberOfStudents = numberOfStudents;
            YearOfFormation = yearOfFormation;
            Specialty = specialty;
        }

        public override string ToString()
        {
            return $"Шифр: {Сipher} \nКоличество студентов: {NumberOfStudents} \nГод формирования: {YearOfFormation} \nСпециальность: {Specialty}";
        }
    }
}
