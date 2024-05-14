using System;

namespace Lab4_Enterprise
{
    public class Factory : Enterprise
    {
        public string ProductType { get; set; }
        public int ProductionVolume { get; set; }

        public Factory(string name, string location, string industry, double successRating, string productType, int productionVolume)
            : base(name, location, industry, successRating)
        {
            ProductType = productType;
            ProductionVolume = productionVolume;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Вид продукції: {ProductType}");
            Console.WriteLine($"Обсяг виробництва: {ProductionVolume}");
        }
    }
}
