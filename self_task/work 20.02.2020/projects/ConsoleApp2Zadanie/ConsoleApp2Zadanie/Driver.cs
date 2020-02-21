using System;

namespace ConsoleApp2Zadanie
{
    class Driver : Worker
    {
        private int drivingExperience;
        private string[] drivingCategory;

        public void SetDrivingExperience(int drivingExperience)
        {
            this.drivingExperience = drivingExperience;
        }

        public int GetDrivingExperience()
        {
            return drivingExperience;
        }

        public void SetDrivingCategory(params string[] drivingCategory)
        {
            this.drivingCategory = drivingCategory;
        }

        public string GetDrivingCategory()
        {
            string countDrivingCategory = "";
            foreach (var item in drivingCategory)
                countDrivingCategory += item + "; ";

            return countDrivingCategory;
        }
    }
}
