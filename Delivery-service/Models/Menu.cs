using System;

namespace Models
{
    public class Menu
    {
        public Menu(string _name, double _price, string _composition, double _weight, int calories)
        {
            Name = _name;
            Price = _price;
            Сomposition = _composition;
            Weight = _weight;
            Calories = calories;
        }
        public string Name { get; set; }

        public double Price { get; set; }

        public string Сomposition { get; set; } 

        public double Weight { get; set; } 

        public int Calories { get; set; } 
    }
}
