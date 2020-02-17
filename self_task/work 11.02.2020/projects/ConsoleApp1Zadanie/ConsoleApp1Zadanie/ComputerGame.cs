using System;

namespace ConsoleApp1Zadanie
{
    class ComputerGame
    {
        public string Name { get; set; }

        public string DeveloperFirm { get; set; }

        public int PublicationDate { get; set; }

        public string Genre { get; set; }

        public ComputerGame(string name, string developerFirm, int publicationDate, string genre)
        {
            Name = name;
            DeveloperFirm = developerFirm;
            PublicationDate = publicationDate;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Название: {Name} \nРазработчик: {DeveloperFirm} \nГод издания: {PublicationDate} \nЖанр: {Genre}";
        }
    }
}
