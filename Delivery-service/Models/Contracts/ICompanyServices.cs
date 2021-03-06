using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface ICompanyServices
    {
        void AddDish(Company company, string name, double price, string composition, double weight, int calories);

        void DeleteDish(Company company, int index);
    }
}
