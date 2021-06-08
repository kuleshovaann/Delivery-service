using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface ICompanyServices
    {
        void AddDish(Company company, string name, double price, string composition, double weight, int calories);

        public void DeleteDish(Company company);
    }
}
