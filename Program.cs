using System;

namespace Lab4_Enterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Enterprise enterprise = new Enterprise("Загальне Підприємство", "Київ", "Послуги", 4.5);
            InsuranceCompany insuranceCompany = new InsuranceCompany("Безпечне Життя", "Львів", "Страхування", 4.8, 5000000, 150);
            Factory factory = new Factory("ТехГер Завод", "Харків", "Виробництво", 4.2, "Електроніка", 20000);

            Console.WriteLine("==== Інформація про підприємство ====");
            enterprise.PrintInfo();
            Console.WriteLine("====================================");

            Console.WriteLine("==== Інформація про страхову компанію ====");
            insuranceCompany.PrintInfo();
            Console.WriteLine("==========================================");

            Console.WriteLine("==== Інформація про завод ====");
            factory.PrintInfo();
            Console.WriteLine("================================");
        }
    }
}
