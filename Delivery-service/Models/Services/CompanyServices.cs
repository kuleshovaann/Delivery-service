using DeliveryService.Models;
using DeliveryService.Contracts;

namespace DeliveryService.Services
{
    public class CompanyServices : ICompanyServices
    {
        private IOrderDatabase _orderDatabase;

        public CompanyServices(IOrderDatabase orderDatabase)
        {
            _orderDatabase = orderDatabase;
        }

        public void AddDish(Company company, string name, double price, string composition, double weight, int calories)
        {
            company.Dishes.Add(new Dish()
            {
                Name = name,
                Price = price,
                Сomposition = composition,
                Weight = weight,
                Calories = calories
            });

            _orderDatabase.DishesBase.Add(new Dish()
            {
                Name = name,
                Price = price,
                Сomposition = composition,
                Weight = weight,
                Calories = calories
            });
        }
    }
}
