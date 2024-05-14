using System;

namespace Lab4_Enterprise
{
    public class InsuranceCompany : Enterprise
    {
        public double Profit { get; set; }
        public int NumberOfEmployees { get; set; }

        public InsuranceCompany(string name, string location, string industry, double successRating, double profit, int numberOfEmployees)
            : base(name, location, industry, successRating)
        {
            Profit = profit;
            NumberOfEmployees = numberOfEmployees;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Прибуток: {Profit}");
            Console.WriteLine($"Кількість співробітників: {NumberOfEmployees}");
        }
    }
}
