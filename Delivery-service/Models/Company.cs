using System;
using System.Collections.Generic;

namespace Models
{
    public class Company : Creator
    {
        public Company(string _name) : base(_name) 
        {
            _menu = new List<Menu>();
        }
        public string BankAccount { get; set; }
        public double Rating { get; set; }

        public List<Menu> _menu;

        public void AddMenu(string name, double price, string composition, double weight, int calories) 
        {         
            _menu.Add(new Menu(name, price, composition, weight, calories));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dish has been added to the menu");
            Console.ResetColor();
        }

        public void ShowMenu()
        {
            var count = 1;
            foreach(var dish in _menu)
            {
                Console.WriteLine($"{count}");
                Console.WriteLine($"Name: {dish.Name}");
                Console.WriteLine($"Price: {dish.Price}");
                Console.WriteLine($"Сomposition: {dish.Сomposition}");
                Console.WriteLine($"Weight: {dish.Weight}");
                Console.WriteLine($"Calories: {dish.Calories}");
                count++;
            }
        }
        void CancelMenu() { }
    }
}
