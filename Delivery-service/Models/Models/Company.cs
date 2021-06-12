using System.Collections.Generic;

namespace DeliveryService.Models
{
    public class Company
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }
        public Company()
        {
            Dishes = new List<Dish>();
        }
    }
}
