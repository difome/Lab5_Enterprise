using System;

namespace Lab4_Enterprise
{
    public class Enterprise
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Industry { get; set; }
        public double SuccessRating { get; set; }

        public Enterprise(string name, string location, string industry, double successRating)
        {
            Name = name;
            Location = location;
            Industry = industry;
            SuccessRating = successRating;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Місцезнаходження: {Location}");
            Console.WriteLine($"Сфера діяльності: {Industry}");
            Console.WriteLine($"Рейтинг успішності: {SuccessRating}");
        }
    }
}
