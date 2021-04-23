using System;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        public Order()
        {
            NumberOfOrder++;
            menu = new List<Menu>();
        }
        public int NumberOfOrder { get; set; } = 0;
        public string Status { get; set; }

        public Customer _customer;

        public Company Company;

        public List<Menu> menu;

        public double FullPrice { get; set; }

        public double FullPriceWithDiscount { get; set; }

        public void AddToOrder(Company company, int index)
        {
            menu.Add(new Menu(company._menu[index - 1].Name, company._menu[index - 1].Price, null, 0.0, 0));
            FullPrice += company._menu[index - 1].Price;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{company._menu[index - 1].Name} has been added to the order");
            Console.ResetColor();
        }
        public void ShowOrder() { }

    }
}
