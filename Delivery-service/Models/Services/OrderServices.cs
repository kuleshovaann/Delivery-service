using System;
using Models.Contracts;
using Models.Models;
using Models.UI;

namespace Models.Services
{
    public class OrderServices
    {
        public static void AddToOrder(ICompany company, Order order, int index)
        {
            while (index <= company.Dishes.Count)
            {
                order.Dishes.Add(new Dish()
                {
                    Name = company.Dishes[index - 1].Name,
                    Price = company.Dishes[index - 1].Price,
                    Сomposition = null,
                    Weight = 0.0,
                    Calories = 0
                });

                order.FullPrice += company.Dishes[index - 1].Price;

                UserUI.GetVerificationOrder(company, index);

                break;
            }
        }
    }
}
