using System;

namespace DeliverySystem.Models
{
    public class Product
    {
        public string Name { get; set; }

        public Сategory ProductСategory { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        public double Weight { get; set; }

        public enum Сategory
        {
            Food,
            Dress,
            HouseholdAppliances,
            Kids,
            HouseholdChemicals,
            Jewelry
        }
    }
}
